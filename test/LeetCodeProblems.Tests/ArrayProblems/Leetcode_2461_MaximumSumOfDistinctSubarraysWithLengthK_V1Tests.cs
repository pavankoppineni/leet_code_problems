using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2461_MaximumSumOfDistinctSubarraysWithLengthK_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMaxSubArray_Then_ShouldReturnmaxSubArray()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 4, 4 };
            var problem = new Leetcode_2461_MaximumSumOfDistinctSubarraysWithLengthK_V1();
            var expectedResult = 9;
            var subArrayLength = 3;

            //When
            var actualResult = problem.CalculateMaximumSubArraySum(values, subArrayLength);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
