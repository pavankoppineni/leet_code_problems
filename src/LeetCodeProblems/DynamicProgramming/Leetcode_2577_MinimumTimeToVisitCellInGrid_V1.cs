using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-to-visit-a-cell-in-a-grid/
    /// </summary>
    public class Leetcode_2577_MinimumTimeToVisitCellInGrid_V1
    {
        private int[][] _directions = new int[4][]
        {
            new int[]{0, -1},//Left
            new int[]{0, 1}, //Right
            new int[]{-1, 0}, //Up
            new int[]{1, 0} //Down
        };
        private int[][] _grid;
        private int _rowCount;
        private int _columnCount;
        private IDictionary<(int row, int column), int> _lookup;
        private bool[,] _visited;
        private int _minTime = -1;

        public int CalculateMinimumTimeToVisitCell(int[][] grid)
        {
            _grid = grid;
            _rowCount = grid.Length;
            _columnCount = grid[0].Length;
            _lookup = new Dictionary<(int row, int column), int>();
            _visited = new bool[_rowCount, _columnCount];
            return 0;
        }

        private void CalculateMinimumTimeToVisitCell(int row, int column, int time)
        {
            if (row == _rowCount - 1 && column == _columnCount - 1)
            {
                _minTime = Math.Min(time, _minTime);
                return;
            }

            foreach (var direction in _directions)
            {
                var newRow = row + direction[0];
                var newColumn = column + direction[1];
                if (newRow < 0 || newRow >= _rowCount)
                {
                    continue;
                }
                if (newColumn < 0 || newColumn >= _columnCount)
                {
                    continue;
                }

                if (_visited[newRow, newColumn])
                {
                    continue;
                }
                var timeNeeded = _grid[newRow][newColumn];
                if (time + 1 < timeNeeded)
                {
                    continue;
                }
                _visited[newRow,newColumn] = true;
                CalculateMinimumTimeToVisitCell(newRow, newColumn, time + 1);
                _visited[newRow,newColumn] = true;
            }
        }
    }
}
