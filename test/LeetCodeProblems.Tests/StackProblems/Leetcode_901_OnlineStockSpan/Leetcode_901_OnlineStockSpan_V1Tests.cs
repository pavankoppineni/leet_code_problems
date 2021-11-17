using LeetCodeProblems.StackProblems.Leetcode_901_OnlineStockSpan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StackProblems.Leetcode_901_OnlineStockSpan
{
    [TestClass]
    public class Leetcode_901_OnlineStockSpan_V1Tests
    {
        [TestMethod]
        public void Given_StreamOfOnlineStockPrices_When_FindPrice_Then_ShouldReturnMaxPrice()
        {
            //Given
            var problem = new Leetcode_901_OnlineStockSpan_V1();
            var expectedPrices = new List<int> { 1, 1, 1, 2, 1 };
            var onlineStockPrices = new List<int> { 100, 80, 60, 70, 60 };
            var actualPrices = new List<int>();

            //When
            foreach (var price in onlineStockPrices)
            {
                actualPrices.Add(problem.Next(price));
            }

            //Then
            for (var index = 0; index < expectedPrices.Count; index++)
            {
                Assert.AreEqual(expectedPrices[index], actualPrices[index]);
            }
        }
    }
}
