using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_931_MinimumFallingPathSum_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_CalculateMinimumFallingPathSum_Then_ReturnMinimumFallingPathSum()
        {
            //Given
            var matrix = new int[3][]
            {
                new int[] { 2, 1, 3},
                new int[] { 6, 5, 4},
                new int[] { 7, 8, 9},
            };
            var problem = new Leetcode_931_MinimumFallingPathSum_V1();
            var expectedResult = 12;

            //When
            var actualResult = problem.CalculateMinimumFallingPathSum(matrix);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
