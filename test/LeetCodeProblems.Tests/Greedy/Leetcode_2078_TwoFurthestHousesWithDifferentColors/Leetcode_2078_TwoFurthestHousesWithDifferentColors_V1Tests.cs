using LeetCodeProblems.Greedy.Leetcode_2078_TwoFurthestHousesWithDifferentColors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_2078_TwoFurthestHousesWithDifferentColors
{
    [TestClass]
    public class Leetcode_2078_TwoFurthestHousesWithDifferentColors_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindFarthestHouses_Then_ShouldCalcualteFarthestHouses()
        {
            //Given
            var houses = new int[] { 4, 4, 4, 11, 4, 4, 11, 4, 4, 4, 4, 4 };
            var problem = new Leetcode_2078_TwoFurthestHousesWithDifferentColors_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.CalculateMaximumDistance(houses);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
