using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-path-in-binary-matrix/
    /// </summary>
    public class Leetcode_1091_ShortestPathInBinaryMatrix_V1
    {
        private int[][] _directions = new int[8][]
        {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 },
            new int[] {-1, -1 },
            new int[] { -1, 1 },
            new int[] { 1, -1 },
            new int[] { 1, 1 }
        };
        private bool[,] _visited;
        private int _rowsCount;
        private int _columnsCount;
        private int[][] _grid;

        public int CalculateShortestPath(int[][] grid)
        {
            _rowsCount = grid.Length;
            _columnsCount = grid[0].Length;
            _visited = new bool[_rowsCount, _columnsCount];
            _grid = grid;
            return CalculateShortestPath(0, 0);
        }

        private int CalculateShortestPath(int row, int column)
        {
            if (row == _rowsCount - 1 && column == _columnsCount - 1)
            {
                return 0;
            }

            if (_grid[row][column] == 1)
            {
                return -1;
            }

            if (_visited[row, column])
            {
                return 0;
            }

            _visited[row, column] = true;
            var minimumPath = int.MaxValue;
            foreach (var direction in _directions)
            {
                var newRow = row + direction[0];
                var newColumn = column + direction[1];
                if (newRow < 0 || newRow >= _rowsCount || newColumn < 0 || newColumn >= _columnsCount)
                {
                    continue;
                }
                if (_visited[newRow, newColumn])
                {
                    continue;
                }
                if (_grid[newRow][newColumn] == 1)
                {
                    continue;
                }
                _visited[newRow, newColumn] = true;
                var pathSum = CalculateShortestPath(newRow, newColumn);
                if (pathSum == -1)
                {
                    continue;
                }
                minimumPath = Math.Min(pathSum + 1, minimumPath);
                _visited[newRow, newColumn] = false;
            }
            return minimumPath;
        }
    }
}
