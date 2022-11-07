using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_2435_PathsInMatrixWhoseSumIsDivisiblebyK_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_CalculatePaths_Then_ShouldReturnNumberOfPaths()
        {
            //Given
            var matrix = new int[3][]
            {
                new int[]{5,2,4},
                new int[]{3,0,5},
                new int[]{0,7,2}
            };
            var expectedResult = 2;
            var problem = new Leetcode_2435_PathsInMatrixWhoseSumIsDivisiblebyK_V1();
            var denominator = 3;

            //When
            var actualResult = problem.CalculateNumberOfPaths(matrix, denominator);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
