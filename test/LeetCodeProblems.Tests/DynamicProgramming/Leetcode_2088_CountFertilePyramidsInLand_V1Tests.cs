using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2088_CountFertilePyramidsInLand_V1Tests
    {
        [TestMethod]
        public void Given_FertileLand_When_CalculateFertilePyramids_Then_ShouldReturnFertilePyramids()
        {
            //Given
            var grid = new int[3][]
            {
                new int[]{1,1,1,1,1},
                new int[]{1,1,1,1,1},
                new int[]{1,1,1,1,1}
            };
            var problem = new Leetcode_2088_CountFertilePyramidsInLand_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateNumberOfPyramids(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
