using System;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-square-submatrices-with-all-ones/
    /// </summary>
    public class Leetcode_1277_CountSquareSubmatricesWithAllOnes_V1
    {
        private int GetMinSquares(int[,] resultMatrix, int row, int col)
        {
            var topRow = row - 1;
            var leftCol = col - 1;
            if (topRow < 0 || leftCol < 0)
            {
                return 0;
            }

            var topLeftMin = Math.Min(resultMatrix[row - 1, col], resultMatrix[row, col - 1]);
            return Math.Min(topLeftMin, resultMatrix[row - 1, col - 1]);
        }

        public int CountSquares(int[][] matrix)
        {
            var rows = matrix.Length;
            var cols = matrix[0].Length;
            var resultMatrix = new int[rows, cols];
            var numberOfMatrices = 0;
            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    var value = matrix[row][col];

                    // When : value is ZERO
                    // Then : do nothing
                    if (value == 0)
                    {
                        resultMatrix[row, col] = 0;
                        continue;
                    }

                    var currentMin = GetMinSquares(resultMatrix, row, col);
                    resultMatrix[row, col] = currentMin + 1;
                    numberOfMatrices += currentMin + 1;
                }
            }

            return numberOfMatrices;
        }
    }
}
