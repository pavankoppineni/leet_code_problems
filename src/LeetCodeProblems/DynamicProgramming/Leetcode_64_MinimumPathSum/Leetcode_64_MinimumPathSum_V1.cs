using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-path-sum/
    /// </summary>
    public class Leetcode_64_MinimumPathSum_V1
    {
        private int[,] _minPathSum;
        private int[][] _matrix;
        public int FindMinimumPathSum(int[][] matrix)
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;
            _minPathSum = new int[rows, columns];
            _matrix = matrix;
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    _minPathSum[row, column] = -1;
                }
            }
            return FindMinimumPathSum(rows - 1, columns - 1);
        }

        private int FindMinimumPathSum(int row, int column)
        {
            if (row < 0 || column < 0)
            {
                return 0;
            }

            if (row == 0 && column == 0)
            {
                return _minPathSum[row, column] = _matrix[row][column];
            }

            if (_minPathSum[row, column] != -1)
            {
                return _minPathSum[row, column];
            }

            var topPath = (row - 1) < 0 ? 0 : FindMinimumPathSum(row - 1, column);
            var leftPath = (column - 1) < 0 ? 0 : FindMinimumPathSum(row, column - 1);

            var minPath = 0;
            if (topPath <= 0 || leftPath <= 0)
            {
                minPath = topPath + leftPath;
            }
            else
            {
                minPath = Math.Min(topPath, leftPath);
            }

            _minPathSum[row, column] = _matrix[row][column] + minPath;

            return _minPathSum[row, column];
        }
    }
}
