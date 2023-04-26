using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_410_SplitArrayLargestSum_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateLargestSum_Then_ShouldReturnLargestSum()
        {
            //Given
            var nums = new int[] {  3, 1, 2, 4, 3 };
            var k = 4;
            var problem = new Leetcode_410_SplitArrayLargestSum_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateSplitArray(nums, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
