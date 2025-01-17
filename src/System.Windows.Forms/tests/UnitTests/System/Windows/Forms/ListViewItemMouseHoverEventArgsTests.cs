﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Windows.Forms.Tests
{
    // NB: doesn't require thread affinity
    public class ListViewItemMouseHoverEventArgsTests
    {
        public static IEnumerable<object[]> Ctor_ListViewItem_TestData()
        {
            yield return new object[] { null };
            yield return new object[] { new ListViewItem() };
        }

        [Theory]
        [MemberData(nameof(Ctor_ListViewItem_TestData))]
        public void Ctor_ListViewItem(ListViewItem item)
        {
            var e = new ListViewItemMouseHoverEventArgs(item);
            Assert.Equal(item, e.Item);
        }
    }
}
