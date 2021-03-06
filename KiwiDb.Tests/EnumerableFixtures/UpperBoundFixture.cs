﻿using System.Collections.Generic;
using KiwiDb.Util;
using NUnit.Framework;

namespace KiwiDb.Tests.EnumerableFixtures
{
    [TestFixture]
    public class UpperBoundFixture
    {
        private IList<T> A<T>(params T[] values)
        {
            return values;
        }

        [Test]
        public void BetweenItemsInList()
        {
            var list = A(0, 2, 4, 6, 8);
            Assert.AreEqual(3, list.UpperBound(5));
        }

        [Test]
        public void BiggerThanAnyInList()
        {
            var list = A(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.AreEqual(10, list.UpperBound(100));
        }

        [Test]
        public void FoundInList()
        {
            var list = A(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.AreEqual(6, list.UpperBound(5));
        }

        [Test]
        public void SmallerThanAnyInList()
        {
            var list = A(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.AreEqual(0, list.UpperBound(-1));
        }
    }
}