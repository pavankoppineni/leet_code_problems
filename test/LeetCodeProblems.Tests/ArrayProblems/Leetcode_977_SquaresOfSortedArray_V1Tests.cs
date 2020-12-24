using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_977_SquaresOfSortedArray_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_SquaresSorted_Then_ShouldReturnArraySortedByTheirSquares()
        {
            //Given
            var values = new int[] { -4, -1, 0, 3, 10 };
            var problem = new Leetcode_977_SquaresOfSortedArray_V1();
            var expectedResult = new int[] { 0, 1, 9, 16, 100 };

            //When
            var actualResult = problem.SortedSquares(values);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            for (var index = 0; index < expectedResult.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
