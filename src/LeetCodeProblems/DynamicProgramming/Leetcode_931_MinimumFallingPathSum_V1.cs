using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-falling-path-sum/
    /// </summary>
    public class Leetcode_931_MinimumFallingPathSum_V1
    {
        private IDictionary<(int row, int column), int> _lookup = new Dictionary<(int row, int column), int>();
        private int _rowCount;
        private int _columnCount;
        private int[][] _matrix;
        private int[][] _directions;
        public int CalculateMinimumFallingPathSum(int[][] matrix)
        {
            _rowCount = matrix.Length;
            _columnCount = matrix[0].Length;
            _matrix = matrix;
            _directions = new int[3][]
            {
                new int[]{ 1, 0 },
                new int[]{ 1, -1 },
                new int[]{ 1, 1 }
            };
            var minValue = int.MaxValue;
            for (var col = 0; col < _columnCount; col++)
            {
                var result = CalculateMinimumFallingPathSum(0, col);
                minValue = Math.Min(minValue, result);
            }
            return minValue;
        }

        private int CalculateMinimumFallingPathSum(int row, int col)
        {
            if (row == _rowCount - 1)
            {
                return _matrix[row][col];
            }

            if (_lookup.ContainsKey((row, col)))
            {
                return _lookup[(row, col)];
            }

            var minValue = int.MaxValue;
            foreach (var direction in _directions)
            {
                var newRow = row + direction[0];
                var newCol = col + direction[1];
                if (newCol < 0 || newCol >= _columnCount)
                {
                    continue;
                }
                var result = CalculateMinimumFallingPathSum(newRow, newCol);
                minValue = Math.Min(minValue, result);
            }
            var value = _matrix[row][col] + minValue;
            _lookup.Add((row, col), value);
            return value;
        }
    }
}
