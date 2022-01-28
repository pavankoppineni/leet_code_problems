using LeetCodeProblems.DynamicProgramming;
using LeetCodeProblems.DynamicProgramming.Leetcode_322_CoinChange;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_322_CoinChange
{
    [TestClass]
    public class Leetcode_322_CoinChange_V1Tests
    {
        [TestMethod]
        public void Given_CoinsAndAmount_When_CountMinimumCoins_Then_ShouldReturnMinimumCoinsRequired()
        {
            //Given
            var coins = new int[] { 186, 419, 83, 408 };
            var amount = 6249;
            var problem = new Leetcode_322_CoinChange_V1();
            var expectedCount = -1;

            //When
            var actualCount = problem.MinCount(coins, amount);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
