using LeetCodeProblems.MatrixProblems.Leetcode_1314_MatrixBlockSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_1314_MatrixBlockSum
{
    [TestClass]
    public class Leetcode_1314_MatrixBlockSum_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_FindBlockSum_Then_ShouldRetunBlockSum()
        {
            //Given
            var matrix = new int[3][]
            {
                new int[]{1, 2, 3},
                new int[]{4, 5, 6},
                new int[]{7, 8, 9}
            };
            var problem = new Leetcode_1314_MatrixBlockSum_V1();
            var expectedMatrix = new int[3][]
            {
                new int[] {1, 2, 3},
                new int[] {1, 2, 3},
                new int[] {1, 2, 3}
            };

            //When
            var actualResult = problem.GetMatrixBlockSum(matrix, 1);

            //Then
            Assert.Inconclusive();
        }
    }
}
