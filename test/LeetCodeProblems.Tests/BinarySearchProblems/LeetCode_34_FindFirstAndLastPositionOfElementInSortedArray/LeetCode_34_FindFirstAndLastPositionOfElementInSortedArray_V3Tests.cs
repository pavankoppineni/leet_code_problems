using LeetCodeProblems.BinarySearchProblems.LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray
{
    [TestClass]
    public class LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V3Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindFirstAndLastIndexes_Then_ShouldReturnFirstAndLastIndex()
        {
            //Given
            var values = new int[] { 0, 0, 0, 1, 2, 3 };
            var problem = new LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V3();
            var expectedRange = new int[] { 0, 2 };

            //When
            var actualValues = problem.SearchRange(values, 0);

            //Then
            Assert.AreEqual(expectedRange[0], actualValues[0]);
            Assert.AreEqual(expectedRange[1], actualValues[1]);
        }
    }
}
