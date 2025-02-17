using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-flips-to-make-binary-grid-palindromic-i/
    /// </summary>
    public class Leetcode_3239_MinimumNumberofFlipstoMakeBinaryGridPalindromic_I_V1
    {
        public int CalculateMinimumFlips(int[][] grid)
        {
            var rows = grid.GetLength(0);
            var cols = grid[0].Length;
            var columnFlips = CalculateMinimumFlipsForColumns(grid, cols);
            var rowFlips = CalculateMinimumFlipsForRows(grid);
            return Math.Min(rowFlips, columnFlips);
        }

        private int CalculateMinimumFlipsForColumns(int[][] grid, int columns)
        {
            var columnFlips = 0;
            for (var column = 0; column < columns; column++)
            {
                var currentFlip = CalculateMinimumFlipsForColumn(grid, column);
                columnFlips += currentFlip;
            }
            return columnFlips;
        }

        private int CalculateMinimumFlipsForColumn(int[][] grid, int column)
        {
            var flips = 0;
            var first = 0;
            var last = grid.Length - 1;
            while (first < last)
            {
                if (grid[first][column] != grid[last][column])
                {
                    flips++;
                }
                first++;
                last--;
            }
            return flips;
        }

        private int CalculateMinimumFlipsForRows(int[][] grid)
        {
            var rowFlips = 0;
            for (var index = 0; index < grid.Length; index++)
            {
                var currentRowFlips = CalculateMinimumFlipForRow(grid[index]);
                rowFlips += currentRowFlips;
            }
            return rowFlips;
        }

        private int CalculateMinimumFlipForRow(int[] row)
        {
            var flips = 0;
            var len = row.Length;
            var first = 0;
            var last = len - 1;
            while (first < last)
            {
                if (row[first] != row[last])
                {
                    flips += 1;
                }
                first++;
                last--;
            }
            return flips;
        }
    }
}
