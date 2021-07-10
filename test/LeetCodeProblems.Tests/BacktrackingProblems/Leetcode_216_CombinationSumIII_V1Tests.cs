using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_216_CombinationSumIII_V1Tests
    {
        [TestMethod]
        public void Given_SumAndK_When_GenerateCombinationSum_Then_ShouldReturnValidCombinations()
        {
            //Given
            var k = 2;
            var sum = 7;
            var expectedValidCombinationsCount = 1;
            var problem = new Leetcode_216_CombinationSumIII_V1();

            //When
            var actualValidCombinations = problem.FindValidCombinations(k, sum);

            //Then
            Assert.AreEqual(expectedValidCombinationsCount, actualValidCombinations.Count);
        }
    }
}
