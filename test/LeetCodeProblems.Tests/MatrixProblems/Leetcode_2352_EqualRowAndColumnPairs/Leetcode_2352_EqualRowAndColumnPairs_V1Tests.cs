using LeetCodeProblems.MatrixProblems.Leetcode_2352_EqualRowAndColumnPairs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_2352_EqualRowAndColumnPairs
{
    [TestClass]
    public class Leetcode_2352_EqualRowAndColumnPairs_V1Tests
    {
        [TestMethod]
        public void Given_IntegerGrid_When_CalculateNumberOfPairs_Then_ShouldReturnNumberOfPairs()
        {
            //Given
            var grid = new int[3][];
            grid[0] = new int[] { 3, 2, 1 };
            grid[1] = new int[] { 1, 7, 6 };
            grid[2] = new int[] { 2, 7, 7 };
            var problem = new Leetcode_2352_EqualRowAndColumnPairs_V1();
            var expectedNumberOfPairs = 1;

            //When
            var actualNumberOfPairs = problem.CalculateEqualPairs(grid);

            //Then
            Assert.AreEqual(expectedNumberOfPairs, actualNumberOfPairs);
        }
    }
}
