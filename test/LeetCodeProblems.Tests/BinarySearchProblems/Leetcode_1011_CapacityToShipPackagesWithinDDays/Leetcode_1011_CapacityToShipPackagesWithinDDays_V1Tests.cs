using LeetCodeProblems.BinarySearchProblems.Leetcode_1011_CapacityToShipPackagesWithinDDays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.Leetcode_1011_CapacityToShipPackagesWithinDDays
{
    [TestClass]
    public class Leetcode_1011_CapacityToShipPackagesWithinDDays_V1Tests
    {
        [TestMethod]
        public void Given_WeightsAndDays_When_CalculateDays_Then_ShouldRetrunMinimumWeightRequired()
        {
            //Given
            var weights = new int[] { 1, 2, 3, 1, 1 };
            var days = 4;
            var problem = new Leetcode_1011_CapacityToShipPackagesWithinDDays_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.ShipWithinDays(weights, days);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
