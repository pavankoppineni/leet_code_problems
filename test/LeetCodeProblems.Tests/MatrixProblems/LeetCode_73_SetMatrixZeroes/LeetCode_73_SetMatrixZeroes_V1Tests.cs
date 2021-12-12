using LeetCodeProblems.MatrixProblems.LeetCode_73_SetMatrixZeroes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.LeetCode_73_SetMatrixZeroes
{
    [TestClass]
    public class LeetCode_73_SetMatrixZeroes_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_SetZeros_Then_ShouldReturnMatrixAfterSettingZeros()
        {
            //Given
            var matrix = new int[][]
            {
                new int[] { 0, 1, 4, 0 },
                new int[] { 3, 4, 5, 2 },
                new int[] { 1, 3, 1, 5 }
            };
            var problem = new LeetCode_73_SetMatrixZeroes_V1();
            var expectedMatrix = new int[][]
            {
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 0, 1 }
            };

            //When
            var actualMatrix = problem.SetZeroes(matrix);

            //Then
            for(var row = 0; row < matrix.Length; row++)
            {
                for (var column = 0; column < matrix[row].Length; column++)
                {
                    Assert.AreEqual(expectedMatrix[row][column], actualMatrix[row][column]);
                }
            }
        }
    }
}
