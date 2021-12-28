using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_1314_MatrixBlockSum
{
    /// <summary>
    /// https://leetcode.com/problems/matrix-block-sum/
    /// </summary>
    public class Leetcode_1314_MatrixBlockSum_V1
    {
        private int _rows;
        private int _columns;
        private int[][] _matrix;
        public int[][] GetMatrixBlockSum(int[][] matrix, int k)
        {
            _matrix = matrix;
            _rows = matrix.Length;
            _columns = matrix[0].Length;
            return PreparePrefixSumMatrix(matrix);
        }

        private int[][] PreparePrefixSumMatrix(int[][] matrix)
        {
            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[row].Length; col++)
                {
                    _matrix[row][col] += GetValue(row, col - 1) + GetValue(row - 1, col) - GetValue(row - 1, col - 1);
                }
            }

            return _matrix;
        }

        private int GetValue(int row, int col)
        {
            if (row < 0 || row >= _rows)
            {
                return 0;
            }

            if (col < 0 || col >= _columns)
            {
                return 0;
            }

            return _matrix[row][col];
        }
    }
}
