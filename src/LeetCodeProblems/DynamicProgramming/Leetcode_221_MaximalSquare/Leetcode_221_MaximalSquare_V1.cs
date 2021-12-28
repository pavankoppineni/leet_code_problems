using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_221_MaximalSquare
{
    /// <summary>
    /// https://leetcode.com/problems/maximal-square/
    /// </summary>
    public class Leetcode_221_MaximalSquare_V1
    {
        private int[,] _dp;
        public int CalculateMaximalSquare(char[][] matrix)
        {
            var result = 0;
            var rows = matrix.Length;
            var cols = matrix[0].Length;
            _dp = new int[rows, cols];
            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    if (matrix[row][col] == '1')
                    {
                        var left = GetValue(row, col - 1);
                        var top = GetValue(row - 1, col);
                        var topLeft = GetValue(row - 1, col - 1);
                        _dp[row, col] = Math.Min(left, Math.Min(top, topLeft));
                        result = Math.Max(result, _dp[row, col]);
                    }
                }
            }
            return result * result;
        }

        private int GetValue(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return 0;
            }
            return _dp[row, col];
        }
    }
}
