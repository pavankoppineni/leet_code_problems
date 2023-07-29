using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-visited-cells-in-a-grid/
    /// </summary>
    public class Leetcode_2617_MinimumNumberOfVisitedCellsInGrid_V1
    {
        private int[][] _grid;
        private int _rowsCount;
        private int _columnsCount;
        private int _totalCells;
        private IDictionary<(int row, int column), int> _lookup;
        public int CalculateMinimumNumberOfVisitedCells(int[][] grid)
        {
            _grid = grid;
            _rowsCount = _grid.Length;
            _columnsCount = _grid[0].Length;
            _totalCells = _rowsCount * _columnsCount;
            _lookup = new Dictionary<(int row, int column), int>();
            return CalculateMinimumNumberOfVisitedCells(0, 0);
        }

        private int CalculateMinimumNumberOfVisitedCells(int row, int column)
        {
            if (_lookup.ContainsKey((row, column)))
            {
                return _lookup[(row, column)];
            }

            if (row < 0 || column < 0 || row >= _rowsCount || column >= _columnsCount)
            {
                return -1;
            }

            if (row == _rowsCount - 1 && column == _columnsCount - 1)
            {
                return 1;
            }

            var lastRow = row + _grid[row][column];
            var lastColumn = column + _grid[row][column];

            var minCellsVisitedCount = _totalCells + 1;
            //Right direction traversal
            for (var colIndex = column + 1; colIndex <= lastColumn; colIndex++)
            {
                if (colIndex >= _columnsCount)
                {
                    break;
                }
                var cellsVisited = CalculateMinimumNumberOfVisitedCells(row, colIndex);
                if (cellsVisited == -1)
                {
                    continue;
                }
                minCellsVisitedCount = Math.Min(minCellsVisitedCount, cellsVisited);
            }

            //Down direction traversal
            for (var rowIndex = row + 1; rowIndex <= lastRow; rowIndex++)
            {
                if (rowIndex >= _rowsCount)
                {
                    break;
                }
                var cellsVisited = CalculateMinimumNumberOfVisitedCells(rowIndex, column);
                if (cellsVisited == -1)
                {
                    continue;
                }
                minCellsVisitedCount = Math.Min(minCellsVisitedCount, cellsVisited);
            }

            if (minCellsVisitedCount == _totalCells + 1)
            {
                _lookup.Add((row, column), -1);
                return -1;
            }
            _lookup.Add((row, column), minCellsVisitedCount + 1);
            return minCellsVisitedCount + 1;
        }
    }
}
