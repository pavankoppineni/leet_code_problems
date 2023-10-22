using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_1091_ShortestPathInBinaryMatrix_V1Tests
    {
        [TestMethod]
        public void Given_Grid_When_CalculateMinimumPath_Then_ShouldReturnMinimumPath()
        {
            //Given
            var grid = new int[3][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 1, 1, 0},
                new int[] { 1, 1, 0}
            };
            var problem = new Leetcode_1091_ShortestPathInBinaryMatrix_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateShortestPath(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
