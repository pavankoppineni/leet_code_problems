using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/increment-submatrices-by-one/
    /// </summary>
    public class Leetcode_2536_IncrementSubmatricesByOne_V1
    {
        public int[][] CalculateRange(int n, int[][] queries)
        {
            var matrix = InitializeMatrix(n);
            foreach (var query in queries)
            {
                var firstRow = query[0];
                var firstColumn = query[1];
                var lastRow = query[2];
                var lastColumn = query[3];

                matrix[firstRow][firstColumn] += 1;
                DecrementNumber(matrix, firstRow, lastColumn + 1);
                DecrementNumber(matrix, firstRow, lastRow + 1);
                DecrementNumber(matrix, lastRow, lastColumn + 1);
            }
            return matrix;
        }

        private void DecrementNumber(int[][] matrix, int row, int column)
        {
            if (row >= matrix.Length)
            {
                return;
            }

            if (column >= matrix.Length)
            {
                return;
            }

            matrix[row][column] -= 1;
        }

        private int[][] InitializeMatrix(int n)
        {
            var matrix = new int[n][];
            for (var i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }
            return matrix;
        }
    }
}
