using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1642_FurthestBuildingYouCanReach_V1Tests
    {
        [TestMethod]
        public void Given_Buildings_When_CalculateFarthestBuilding_Then_ShouldReturnFarthestBuilding()
        {
            //Given
            var building = new int[] { 1, 5, 1, 2, 3, 4, 10000 };
            var ladders = 1;
            var bricks = 4;
            var problem = new Leetcode_1642_FurthestBuildingYouCanReach_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateFurthestBuilding(building, bricks, ladders);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
