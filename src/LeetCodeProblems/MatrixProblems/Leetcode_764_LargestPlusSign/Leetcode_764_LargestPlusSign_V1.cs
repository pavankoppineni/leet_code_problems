using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_764_LargestPlusSign
{
    /// <summary>
    /// https://leetcode.com/problems/largest-plus-sign/
    /// </summary>
    public class Leetcode_764_LargestPlusSign_V1
    {
        public int CalculateOrderOfPlusSign(int n, int[][] mines)
        {
            if (n == 1)
            {
                return mines[0][0] == 0 ? 0 : 1;
            }

            var cells = new Cell[n, n];
            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    cells[row, col] = new Cell(false);
                }
            }

            foreach (var mine in mines)
            {
                cells[mine[0], mine[1]].IsZero = true;
            }

            for (var row = 1; row < n - 1; row++)
            {
                for (var col = 1; col < n - 1; col++)
                {
                    if (cells[row, col].IsZero)
                    {
                        continue;
                    }
                    var leftCell = cells[row, col - 1];
                    var topCell = cells[row - 1, col];
                    cells[row, col].Left = leftCell.IsZero ? 0 : leftCell.Left + 1;
                    cells[row, col].Up = topCell.IsZero ? 0 : topCell.Up + 1;
                }
            }

            for (var row = n - 2; row > 0; row--)
            {
                for (var col = n - 2; col > 0; col--)
                {
                    if (cells[row, col].IsZero)
                    {
                        continue;
                    }
                    var rightCell = cells[row, col + 1];
                    var downCell = cells[row + 1, col];
                    cells[row, col].Right = rightCell.IsZero ? 0 : rightCell.Right + 1;
                    cells[row, col].Down = downCell.IsZero ? 0 : downCell.Down + 1;
                }
            }

            var maxOrder = cells[0, 0].CalculateOrder();
            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    var cell = cells[row, col];
                    if (cell.IsZero)
                    {
                        continue;
                    }
                    var currentOrder = cell.CalculateOrder();
                    maxOrder = Math.Max(maxOrder, currentOrder + 1);
                }
            }

            return maxOrder;
        }

        public class Cell
        {
            public Cell(bool isZero)
            {
                IsZero = isZero;
            }

            public int Left { get; set; }
            public int Right { get; set; }
            public int Up { get; set; }
            public int Down { get; set; }
            public bool IsZero { get; set; }
            public int CalculateOrder()
            {
                if (IsZero)
                {
                    return 0;
                }

                return Math.Min(Math.Min(Left, Right), Math.Min(Down, Up));
            }
        }
    }
}
