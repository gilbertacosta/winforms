﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Drawing;

namespace System.Windows.Forms.Design.Behavior
{
    /// <summary>
    ///  The LockedBorderGlyph draws one side (depending on type) of a SelectionBorder in the 'Locked' mode.
    ///  The constructor will initialize and cache the pen and brush objects to avoid unnecessary recreations.
    /// </summary>
    internal class LockedBorderGlyph : SelectionGlyphBase
    {
        /// <summary>
        ///  This constructor extends from the standard SelectionGlyphBase constructor.
        ///  Note that a primarySelection flag is passed in - this will be used when determining the colors of the borders.
        /// </summary>
        internal LockedBorderGlyph(Rectangle controlBounds, SelectionBorderGlyphType type)
            : base(null)
        {
            InitializeGlyph(controlBounds, type);
        }

        /// <summary>
        ///  Helper function that initializes the Glyph based on bounds, type, primary sel, and bordersize.
        /// </summary>
        private void InitializeGlyph(Rectangle controlBounds, SelectionBorderGlyphType type)
        {
            hitTestCursor = Cursors.Default; // always default cursor for locked
            rules = SelectionRules.None; // never change sel rules for locked

            // this will return the rect representing the bounds of the glyph
            bounds = DesignerUtils.GetBoundsForSelectionType(controlBounds, type);
            hitBounds = bounds;
        }

        /// <summary>
        ///  Simple painting logic for locked Glyphs.
        /// </summary>
        public override void Paint(PaintEventArgs pe)
        {
            DesignerUtils.DrawSelectionBorder(pe.Graphics, bounds);
        }
    }
}
