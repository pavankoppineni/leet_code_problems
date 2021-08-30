using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_122_BestTimeToBuyAndSellStock_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindMaxProfit_Then_ShouldReturnMaxProfit()
        {
            //Given
            var values = new int[] { 7, 1, 2, 10, 3, 4, 5 };
            var problem = new Leetcode_122_BestTimeToBuyAndSellStock_V1();
            var expectedMaxProfit = 11;

            //When
            var actualMaxProfit = problem.FindMaxProfit(values);

            //Then
            Assert.AreEqual(expectedMaxProfit, actualMaxProfit);
        }
    }
}
