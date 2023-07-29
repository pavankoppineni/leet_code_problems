using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths-iii/
    /// </summary>
    public class Leetcode_980_UniquePaths_III_V1
    {
        private int _rows, _columns;
        private int[][] _directions = new int[4][]
        {
            new int[] {0, 1},
            new int[] {0, -1},
            new int[] {1, 0},
            new int[] {-1, 0}
        };
        private bool[,] _visited;
        private int[][] _grid;
        private int _numberOfEmptyCells;
        public int CalculateUniquePaths(int[][] grid)
        {
            _rows = grid.GetLength(0);
            _columns = grid[0].Length;
            _visited = new bool[_rows, _columns];
            _grid = grid;
            (int row, int col) startCell = (0, 0);
            for (var row = 0; row < _rows; row++)
            {
                for (var col = 0; col < _columns; col++)
                {
                    var cellValue = _grid[row][col];
                    if (cellValue == 0)
                    {
                        _numberOfEmptyCells += 1;
                        continue;
                    }
                    if (cellValue == 1)
                    {
                        startCell = (row, col);
                    }
                }
            }
            _visited[startCell.row, startCell.col] = true;
            return CalculateUniquePaths(startCell.row, startCell.col, 0);
        }

        private int CalculateUniquePaths(int row, int col, int visitedEmptyCells)
        {
            if (row < 0 || col < 0)
            {
                return 0;
            }

            if (row >= _rows || col >= _columns)
            {
                return 0;
            }

            if (_grid[row][col] == -1)
            {
                return 0;
            }

            if (_grid[row][col] == 2)
            {
                if (visitedEmptyCells == _numberOfEmptyCells)
                {
                    return 1;
                }
                return 0;
            }

            //_visited[row, col] = true;
            var uniquePaths = 0;
            foreach (var direction in _directions)
            {
                var newRow = row + direction[0];
                var newCol = col + direction[1];
                if (newRow < 0 || newCol < 0)
                {
                    continue;
                }

                if (newRow >= _rows || newCol >= _columns)
                {
                    continue;
                }

                if (_grid[newRow][newCol] == -1)
                {
                    continue;
                }

                if (_visited[newRow, newCol])
                {
                    continue;
                }
                if (_grid[newRow][newCol] == 0)
                {
                    visitedEmptyCells += 1;
                    _visited[newRow, newCol] = true;
                }
                uniquePaths += CalculateUniquePaths(newRow, newCol, visitedEmptyCells);
                if (_grid[newRow][newCol] == 0)
                {
                    visitedEmptyCells -= 1;
                    _visited[newRow, newCol] = false;
                }
            }
            return uniquePaths;
        }
    }
}
