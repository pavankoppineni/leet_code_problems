using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_64_MinimumPathSum_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_FindMinimumPathSum_Then_ShouldReturnMinimumPathSum()
        {
            //Given
            var matrix = new int[2][];
            matrix[0] = new int[] { 1, 3 };
            matrix[1] = new int[] { 1, 5 };
            //matrix[2] = new int[] { 4, 2, 1 };
            var problem = new Leetcode_64_MinimumPathSum_V1();
            var expectedResult = 7;

            //When
            var actualResult = problem.FindMinimumPathSum(matrix);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
