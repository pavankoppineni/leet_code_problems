using LeetCodeProblems.DynamicProgramming.Leetcode_368_LargestDivisibleSubset;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_368_LargestDivisibleSubset
{
    [TestClass]
    public class Leetcode_368_LargestDivisibleSubset_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindLargestDivisibleSubset_Then_ShouldReturnLargestSubset()
        {
            //Given
            var values = new int[] { 1, 2, 4, 8 };
            var problem = new Leetcode_368_LargestDivisibleSubset_V1();
            var expectedCount = 4;

            //When
            var actualResult = problem.FindLargestDivisibleSubset(values);

            //Then
            Assert.AreEqual(expectedCount, actualResult.Count);
        }
    }
}
