using LeetCodeProblems.DynamicProgramming.Leetcode_2008_MaximumEarningsFromTaxi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_2008_MaximumEarningsFromTaxi
{
    [TestClass]
    public class Leetcode_2008_MaximumEarningsFromTaxi_RecursionTests
    {
        [TestMethod]
        public void Given_Trips_When_CalculateMaximumEarnings_Then_ShouldReturnMaximumEarnings()
        {
            //Given
            //[[1,6,1],[3,10,2],[10,12,3],[11,12,2],[12,15,2],[13,18,1]]
            var trips = new int[][]
            {
                new int[]{1, 6, 1},
                new int[]{3, 10, 2},
                new int[]{10, 12, 3},
                new int[]{11, 12, 2},
                new int[]{12, 15, 2},
                new int[]{13, 18, 1}
            };
            var problem = new Leetcode_2008_MaximumEarningsFromTaxi_Recursion();
            var expectedResult = 7;
            var stops = 18;

            //When
            var actualResult = problem.CalculateMaximumEarnings(stops, trips);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
