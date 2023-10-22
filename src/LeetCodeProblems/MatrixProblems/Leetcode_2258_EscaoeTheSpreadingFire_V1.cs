using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/escape-the-spreading-fire
    /// </summary>
    public class Leetcode_2258_EscaoeTheSpreadingFire_V1
    {
        int[][] _directions = new int[][]
        {
            new int[] { 0, 1 },
            new int[] { 0, -1 },
            new int[] { 1, 0 },
            new int[] {-1, 0 }
        };
        int _columnCount;
        int _rowCount;
        public int CalculateMaximumMinutes(int[][] grid)
        {
            _rowCount = grid.Length;
            _columnCount = grid[0].Length;
            var (cells, fireStack) = GetGridAggregate(grid);
            CalculateFireSpread(cells, fireStack);
            return 0;
        }

        private void CalculateFireSpread(Cell[][] cells, Stack<(int row, int col)> stack)
        {
            while (stack.Count > 0)
            {
                var (row, col) = stack.Pop();
                var currentCell = cells[row][col];
                foreach (var direction in _directions)
                {
                    var newRow = row + direction[0];
                    if (newRow < 0 || newRow >= _rowCount)
                    {
                        continue;
                    }
                    var newColumn = col + direction[1];
                    if (newColumn < 0 || newColumn >= _columnCount)
                    {
                        continue;
                    }

                    var cell = cells[newRow][newColumn];
                    if (cell.Type == CellType.Fire)
                    {
                        continue;
                    }
                    if (cell.NumberOfMinutes > 0)
                    {
                        continue;
                    }
                    cell.NumberOfMinutes = currentCell.NumberOfMinutes + 1;
                    stack.Push((newRow, newColumn));
                }
            }
        }

        private (Cell[][] cells, Stack<(int row, int col)> fireStack) GetGridAggregate(int[][] grid)
        {
            var cells = new Cell[grid.Length][];
            var fireStack = new Stack<(int row, int col)>();
            for (var row = 0; row < grid.Length; row++)
            {
                cells[row] = new Cell[grid[0].Length];
                for (var col = 0; col < grid[row].Length; col++)
                {
                    var cell = new Cell();
                    if (grid[row][col] == 1)
                    {
                        cell.Type = CellType.Fire;
                        fireStack.Push((row, col));
                    }
                    else if (grid[row][col] == 2)
                    {
                        cell.Type = CellType.Wall;
                        cell.NumberOfMinutes = -1;
                    }
                    else
                    {
                        cell.NumberOfMinutes = -1;
                        cell.Type = CellType.Grass;
                    }
                    cells[row][col] = cell;
                }
            }
            return (cells, fireStack);
        }
    }

    public class GridAggregate
    {
        public GridAggregate(Cell[][] grid, Stack<(int row, int col)> fireStack)
        {
            Grid = grid;
            FireStack = fireStack;
        }
        public Cell[][] Grid { get; set; }
        public Stack<(int row, int col)> FireStack { get; set; }
    }

    public class Cell
    {
        public CellType Type { get; set; }
        public int NumberOfMinutes { get; set; }
    }

    public enum CellType
    {
        Grass = 0,
        Fire = 1,
        Wall = 2
    }
}
