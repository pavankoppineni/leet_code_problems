using LeetCodeProblems.DynamicProgramming.Leetcode_188_BestTimeToBuyAndSellStockIV;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_188_BestTimeToBuyAndSellStockIV
{
    [TestClass]
    public class Leetcode_188_BestTimeToBuyAndSellStockIV_V1Tests
    {
        [TestMethod]
        public void Given_StockValues_When_CalculateProfit_Then_ShouldReturnMaximumProfitInKTransactions()
        {
            //Given
            var values = new int[] { 1, 2, 4, 2 };
            var transactionsCount = 2;
            var problem = new Leetcode_188_BestTimeToBuyAndSellStockIV_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMaximumProfit(values, transactionsCount);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
