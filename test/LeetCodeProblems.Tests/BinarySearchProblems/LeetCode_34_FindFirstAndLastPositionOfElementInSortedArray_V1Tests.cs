using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindFirstAndLastPosition_Then_ShouldReturnFirstAndLastPosition()
        {
            //Given
            var values = new int[]{5, 7, 7, 8, 8, 10};
            var problem = new LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V1();
            var expectedResult = (start: 3, end: 4);
            var target = 8;

            //When
            var actualResult = problem.SearchRange(values, target);

            //Then
            Assert.AreEqual(expectedResult.start, actualResult[0]);
            Assert.AreEqual(expectedResult.end, actualResult[1]);
        }
    }
}
