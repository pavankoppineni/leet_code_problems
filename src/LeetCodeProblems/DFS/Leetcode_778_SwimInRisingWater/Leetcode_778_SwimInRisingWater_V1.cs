using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DFS.Leetcode_778_SwimInRisingWater
{
    /// <summary>
    /// https://leetcode.com/problems/swim-in-rising-water/
    /// </summary>
    public class Leetcode_778_SwimInRisingWater_V1
    {
        private static int[][] _directions = new int[4][]
        {
            new int[]{0,1 },
            new int[]{0,-1 },
            new int[]{1,0 },
            new int[]{-1,0 }
        };
        private bool[,] _visited;
        private int[][] _grid;
        private int _result;

        public int CalculateSwimWater(int[][] grid)
        {
            _grid = grid;
            _visited = new bool[grid.Length, grid.Length];
            _result = -1;
            CalculateSwimWater(0, 0, _grid[0][0]);
            return _result;
        }

        private void CalculateSwimWater(int row, int col, int currentLevel)
        {
            if (row == _grid.Length - 1 && col == _grid.Length - 1)
            {
                if (_result == -1)
                {
                    _result = currentLevel;
                    return;
                }
                _result = Math.Min(_result, currentLevel);
                return;
            }

            foreach (var direction in _directions)
            {
                var newRow = row + direction[0];
                var newCol = col + direction[1];
                if (newRow < 0 || newCol < 0)
                {
                    continue;
                }
                if (newRow >= _grid.Length || newCol >= _grid.Length)
                {
                    continue;
                }
                if (_visited[newRow, newCol])
                {
                    continue;
                }
                _visited[newRow, newCol] = true;
                CalculateSwimWater(newRow, newCol, Math.Max(currentLevel, _grid[newRow][newCol]));
                _visited[newRow, newCol] = false;
            }
        }
    }
}
