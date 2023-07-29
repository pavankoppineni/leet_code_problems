using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2617_MinimumNumberOfVisitedCellsInGrid_V1Tests
    {
        [TestMethod]
        public void Given_Grid_When_CalculateMinimumVisitedCells_Then_ShouldReturnMinimumVisitedCells()
        {
            //Given
            var grid = new int[4][]
            {
                new int[]{ 3,4,2,1},
                new int[]{ 4,3,2,1},
                new int[]{ 2,1,0,0},
                new int[]{ 2,4,0,0},
            };
            var problem = new Leetcode_2617_MinimumNumberOfVisitedCellsInGrid_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateMinimumNumberOfVisitedCells(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
