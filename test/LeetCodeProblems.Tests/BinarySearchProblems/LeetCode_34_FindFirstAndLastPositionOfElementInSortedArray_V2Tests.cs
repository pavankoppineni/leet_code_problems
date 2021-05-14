using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V2Tests
    {
        [TestMethod]
        public void Given_SortedArrayAndTarget_When_SearchRange_Then_ShouldReturnRangeArray()
        {
            //Given
            var values = new int[] { 5, 7, 7, 8, 8, 10 };
            var problem = new LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V2();
            var expectedResult = new int[] { 3, 4 };
            var target = 8;

            //When
            var actualResult = problem.SearchRange(values, target);

            //Then
            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
        }
    }
}
