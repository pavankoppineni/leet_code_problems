using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_695_MaxAreaOfIsland
{
    /// <summary>
    /// https://leetcode.com/problems/max-area-of-island/
    /// </summary>
    public class Leetcode_695_MaxAreaOfIsland_V1
    {
        private readonly int[][] _directions;
        private bool[,] _visited;
        private int[][] _matrix;
        public Leetcode_695_MaxAreaOfIsland_V1()
        {
            _directions = new int[4][]
            {
                new int[] { 0, 1},
                new int[] { 0, -1},
                new int[] {-1, 0},
                new int[] {1, 0}
            };
        }

        public int MaxAreaOfIsland(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            _visited = new bool[rows, cols];
            _matrix = grid;
            var maxArea = 0;

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    var cell = grid[row][col];
                    if (_visited[row, col])
                    {
                        continue;
                    }
                    _visited[row, col] = true;
                    if (cell == 0)
                    {
                        continue;
                    }
                    var area = CalculateAreaOfIsland(row, col, 1);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
            return maxArea;
        }

        private int CalculateAreaOfIsland(int row, int col, int area)
        {
            foreach (var direction in _directions)
            {
                var newRow = row + direction[0];
                var newCol = col + direction[1];

                if (newRow < 0 || newRow >= _matrix.Length)
                {
                    continue;
                }

                if (newCol < 0 || newCol >= _matrix[0].Length)
                {
                    continue;
                }

                if (_visited[newRow, newCol])
                {
                    continue;
                }
                _visited[newRow, newCol] = true;
                if (_matrix[newRow][newCol] == 0)
                {
                    continue;
                }
                area = CalculateAreaOfIsland(newRow, newCol, area + 1);
            }

            return area;
        }
    }
}
