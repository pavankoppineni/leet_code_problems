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
        private Dictionary<Tuple<int, int>, int> _minPathSum;
        private int[][] _matrix;
        public int FindMinimumPathSum(int[][] matrix)
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;
            _minPathSum = new Dictionary<Tuple<int, int>, int>();
            _matrix = matrix;
            return FindMinimumPathSum(rows - 1, columns - 1);
        }

        private int FindMinimumPathSum(int row, int column)
        {
            var tuple = new Tuple<int, int>(row, column);
            if (_minPathSum.ContainsKey(tuple))
            {
                return _minPathSum[tuple];
            }

            var sum = 0;
            var topPathValid = IsValid(row - 1, column);
            var leftPathValid = IsValid(row, column - 1);
            if (topPathValid && leftPathValid)
            {
                sum = Math.Min(FindMinimumPathSum(row - 1, column), FindMinimumPathSum(row, column - 1));
            }
            else if (topPathValid)
            {
                sum = FindMinimumPathSum(row - 1, column);
            }
            else if (leftPathValid)
            {
                sum = FindMinimumPathSum(row, column - 1);
            }
            _minPathSum.Add(tuple, sum + _matrix[row][column]);
            return sum + _matrix[row][column];
        }

        private bool IsValid(int row, int column)
        {
            if (row < 0 || column < 0)
            {
                return false;
            }
            if (row >= _matrix.Length || column >= _matrix[0].Length)
            {
                return false;
            }
            return true;
        }
    }
}
