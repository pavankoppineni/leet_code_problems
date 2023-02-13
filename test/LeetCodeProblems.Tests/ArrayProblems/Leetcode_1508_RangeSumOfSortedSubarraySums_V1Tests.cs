using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1508_RangeSumOfSortedSubarraySums_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateRangeSum_Then_ShouldReturnRangeSum()
        {
            //Given
            var nums = new int[] { 1, 2, 3, 4 };
            var len = 4;
            var problem = new Leetcode_1508_RangeSumOfSortedSubarraySums_V1();
            var expectedResult = 0;

            //When
            var actualResult = problem.RangeSum(nums, len, 1, 5);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
