using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-moves-in-a-grid/
    /// </summary>
    public class Leetcode_2684_MaximumNumberOfMovesInGrid_V1
    {
        private IDictionary<(int row, int col), int> _movesLookup;
        private int[][] _grid;
        private int _rows;
        private int _cols;
        public int CalculateMaximumMoves(int[][] grid)
        {
            _grid = grid;
            _movesLookup = new Dictionary<(int row, int col), int>();
            _rows = grid.Length;
            _cols = grid[0].Length;
            var maxMoves = 0;
            for (var row = 0; row < _rows; row++)
            {
                var numberOfMoves = CalculateMaximumMoves(row, 0, -1);
                maxMoves = Math.Max(maxMoves, numberOfMoves);
            }
            return maxMoves;
        }

        private int CalculateMaximumMoves(int row, int col, int previousValue)
        {
            if (row < 0 || row >= _rows)
            {
                return 0;
            }
            if (col < 0 || col >= _cols)
            {
                return 0;
            }

            if (_movesLookup.ContainsKey((row, col)))
            {
                return _movesLookup[(row, col)];
            }

            var currentValue = _grid[row][col];
            if (currentValue <= previousValue)
            {
                return 0;
            }
            var topRight = CalculateMaximumMoves(row, col + 1, currentValue);
            var right = CalculateMaximumMoves(row - 1, col + 1, currentValue);
            var bottomRight = CalculateMaximumMoves(row + 1, col + 1, currentValue);
            var moves = Math.Max(Math.Max(topRight, right), bottomRight) + 1;
            _movesLookup.Add((row, col), moves);
            return moves;
        }
    }
}
