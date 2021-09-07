using LeetCodeProblems.ArrayProblems;
using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class Leetcode_4_MedianOfTwoSortedArrays_V1Tests
    {
        [TestMethod]
        public void Given_TwoSortedArrays_When_FindMedian_Then_ShouldReturnMedian()
        {
            //Given
            var arrayOne = new int[] { 1, 12, 15, 26, 38 };
            var arrayTwo = new int[] { 2, 13, 17, 30, 45 };
            var problem = new Leetcode_4_MedianOfTwoSortedArrays_V1();
            var expectedResult = 16;

            //When
            var actualResult = problem.FindMedian(arrayOne, arrayTwo);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
