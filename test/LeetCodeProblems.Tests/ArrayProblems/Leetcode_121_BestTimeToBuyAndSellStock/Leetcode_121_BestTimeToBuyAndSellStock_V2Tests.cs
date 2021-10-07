using LeetCodeProblems.ArrayProblems.Leetcode_121_BestTimeToBuyAndSellStock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_121_BestTimeToBuyAndSellStock
{
    [TestClass]
    public class Leetcode_121_BestTimeToBuyAndSellStock_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMaxProfit_Then_ShouldReturnMaxProfit()
        {
            //Given
            var values = new int[] { 7, 1, 5, 3, 6, 4 };
            var problem = new Leetcode_121_BestTimeToBuyAndSellStock_V2();
            var expectedResult = 5;

            //When
            var actualResult = problem.CalculateProfit(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
