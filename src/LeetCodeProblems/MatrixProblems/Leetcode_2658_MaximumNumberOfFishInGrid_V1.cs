using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-fish-in-a-grid/
    /// </summary>
    public class Leetcode_2658_MaximumNumberOfFishInGrid_V1
    {
        private int[][] _directions;
        private bool[][] _visited;
        private int _rowCount;
        private int _columnCount;
        public Leetcode_2658_MaximumNumberOfFishInGrid_V1()
        {
            this._directions = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, -1 },
                new int[] { 1, 0 },
                new int[] { -1, 0 },
            };
        }

        public int CalculateMaximumNumberOfFish(int[][] grid)
        {
            _rowCount = grid.Length;
            _columnCount = grid[0].Length;
            this._visited = new bool[_rowCount][];
            for (var rowIndex = 0; rowIndex < _rowCount; rowIndex++)
            {
                for (var colIndex = 0; colIndex < _columnCount; colIndex++)
                {
                    this._visited[rowIndex][colIndex] = false;
                }
            }

            var maxNumberOfFishes = 0;
            for (var rowIndex = 0; rowIndex < _rowCount; ++rowIndex)
            {
                for (var colIndex = 0; colIndex < _columnCount; colIndex++)
                {
                    if (this._visited[rowIndex][colIndex])
                    {
                        continue;
                    }

                    var numberOfFishes = GetCountOfFish(rowIndex, colIndex);
                    maxNumberOfFishes = Math.Max(maxNumberOfFishes, numberOfFishes);
                }
            }

            return maxNumberOfFishes;
        }

        private int GetCountOfFish(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return 0;
            }

            if (row >= _rowCount || col >= _columnCount)
            {
                return 0;
            }

            if (this._visited[row][col])
            {
                return 0;
            }

            this._visited[row][col] = true;
            var numberOfFishes = 0;
            foreach (var direction in this._directions)
            {
                var newRow = row + direction[0];
                var newCol = col + direction[1];
                numberOfFishes += GetCountOfFish(newRow, newCol);
            }

            return numberOfFishes;
        }
    }
}
