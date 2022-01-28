using LeetCodeProblems.DynamicProgramming.Leetcode_983_MinimumCostForTickets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_983_MinimumCostForTickets
{
    [TestClass]
    public class Leetcode_983_MinimumCostForTickets_RecursionTests
    {
        [TestMethod]
        public void Given_DaysAndCosts_When_CalculateMinimum_Then_ShouldReturnMinimumCost()
        {
            //Given
            var days = new int[] { 3, 5, 6, 8, 11, 13, 15, 16, 17, 18, 19, 20, 24, 27, 30, 31, 33, 36, 37, 40, 45, 48, 51, 54, 56, 57, 61, 62, 64, 66, 67, 71, 73, 74, 77, 78, 80, 81, 83, 84, 86, 87, 90, 91, 94, 96, 97 };
            var costs = new int[] { 3, 16, 66 };
            var problem = new Leetcode_983_MinimumCostForTickets_Recursion();
            var expectedResult = 139;

            //When
            var actualResult = problem.CalculateMinimumCost(days, costs);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
