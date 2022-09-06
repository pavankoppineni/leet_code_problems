using LeetCodeProblems.ArrayProblems.Leetcode_930_BinarySubarrayWithSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_930_BinarySubarrayWithSum
{
    [TestClass]
    public class Leetcode_930_BinarySubarrayWithSum_V1Tests
    {
        [TestMethod]
        public void Given_BinaryArray_When_CalculateNumberOfSubarraysWithGivenTarget_Then_ShouldReturnNumberOfSubarrays()
        {
            //Given
            var values = new int[] { 1, 0, 1, 0, 1 };
            var target = 2;
            var problem = new Leetcode_930_BinarySubarrayWithSum_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateCountOfSubarrays(values, target);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
