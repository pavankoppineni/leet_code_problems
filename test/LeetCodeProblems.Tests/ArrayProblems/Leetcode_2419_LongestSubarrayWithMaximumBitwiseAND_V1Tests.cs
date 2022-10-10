using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2419_LongestSubarrayWithMaximumBitwiseAND_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateLongestSubArray_Then_ShouldReturnMaximumSubarray()
        {
            //Given
            var values = new int[] { 1, 2, 3, 3, 2, 2, 2, 7 };
            var problem = new Leetcode_2419_LongestSubarrayWithMaximumBitwiseAND_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMaximumLength(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
