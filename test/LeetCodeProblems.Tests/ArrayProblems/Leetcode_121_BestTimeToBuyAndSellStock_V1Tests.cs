using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_121_BestTimeToBuyAndSellStock_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindMaxProfit_Then_ShouldReturnMaxProfit()
        {
            //Given
            var values = new int[] { 7, 1, 5, 3, 6, 4 };
            var problem = new Leetcode_121_BestTimeToBuyAndSellStock_V1();
            var expectedMaxProfit = 5;

            //When
            var actualMaxProfit = problem.GetMaxProfit(values);

            //Then
            Assert.AreEqual(expectedMaxProfit, actualMaxProfit);
        }
    }
}
