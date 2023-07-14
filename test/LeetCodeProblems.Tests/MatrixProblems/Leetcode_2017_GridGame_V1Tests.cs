using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_2017_GridGame_V1Tests
    {
        [TestMethod]
        public void Given_Grid_When_CalculateOptimalPoints_Then_ShouldReturnOptimalPoints()
        {
            //Given
            var grid = new int[2][]
            {
                new int[]{ 20,3,20,17,2,12,15,17,4,15 },
                new int[]{ 20, 10, 13, 14, 15, 5, 2, 3, 14, 3 }
            };
            var problem = new Leetcode_2017_GridGame_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.GridGame(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
