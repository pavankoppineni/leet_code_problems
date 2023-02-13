using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_948_BagOfTokens_V1Tests
    {
        [TestMethod]
        public void Given_TokensAndPower_Then_CalculateScore_Then_ShouldReturnMaximumScore()
        {
            //Given
            var tokens = new int[] { 100 };
            var power = 50;
            var problem = new Leetcode_948_BagOfTokens_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateScore(tokens, power);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
