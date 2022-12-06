using LeetCodeProblems.DFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DFS
{
    [TestClass]
    public class Leetcode_2477_MinimumFuelCostToReportToCapital_V1Tests
    {
        [TestMethod]
        public void Given_RoadsAndSeats_When_CalculateMinimumFuel_Then_ShouldReturnMinimumFuel()
        {
            //Given
            var roads = new int[6][]
            {
                new int[]{3, 1},
                new int[]{3, 2},
                new int[]{1, 0},
                new int[]{0, 4},
                new int[]{0, 5},
                new int[]{4, 6},
            };
            var seats = 2;
            var problem = new Leetcode_2477_MinimumFuelCostToReportToCapital_V1();
            var expectedResult = 7;

            //When
            var actualResult = problem.CalculateMinimumFuelRequired(roads, seats);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
