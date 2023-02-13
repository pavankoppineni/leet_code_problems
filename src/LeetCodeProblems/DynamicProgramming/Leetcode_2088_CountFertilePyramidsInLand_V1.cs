using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/count-fertile-pyramids-in-a-land/
    /// </summary>
    public class Leetcode_2088_CountFertilePyramidsInLand_V1
    {
        private IDictionary<(int row, int col), (int val, int height)> _lookup;
        private int _rowCount;
        private int _columnCount;
        private int[][] _grid;
        private int[][] _downDirections;
        public int CalculateNumberOfPyramids(int[][] grid)
        {
            _lookup = new Dictionary<(int row, int col), (int val, int height)>();
            _downDirections = new int[3][]
            {
                new int[]{1,-1},
                new int[]{1, 1},
                new int[]{1, 0}
            };
            _grid = grid;
            _rowCount = grid.Length;
            _columnCount = grid[0].Length;
            for (var col = 0; col < _columnCount; col++)
            {
                var result = CalculateNumberOfPyramids(0, col);
            }
            return 0;
        }

        private (int val, int height) CalculateNumberOfPyramids(int row, int column)
        {
            if (row >= _rowCount)
            {
                return (0, 0);
            }
            if (column >= _columnCount || column < 0)
            {
                return (0, 0);
            }

            if (_lookup.ContainsKey((row, column)))
            {
                return _lookup[(row, column)];
            }

            if (_grid[row][column] == 0)
            {
                return (0, 0);
            }

            if (row == _rowCount - 1)
            {
                return (1, 1);
            }

            var height = int.MaxValue;
            foreach (var direction in _downDirections)
            {
                var newRow = row + direction[0];
                var newColumn = column + direction[1];
                var childPyramidResult = CalculateNumberOfPyramids(newRow, newColumn);
                if (childPyramidResult.val == 0)
                {
                    height = 0;
                    break;
                }
                height = Math.Min(height, childPyramidResult.height);
            }
            var result = (1, height + 1);
            _lookup.Add((row, column), result);
            return result;
        }
    }
}
