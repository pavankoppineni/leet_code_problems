using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-unguarded-cells-in-the-grid/
    /// </summary>
    public class Leetcode_2257_CountUnguardedCellsintheGrid_V1
    {
        public int CountUnguardedCells(int rows, int columns, int[][] guards, int[][] walls)
        {
            return -1;
        }

        private int[][] ConstructGrid(int rows, int columns)
        {
            var grid = new int[rows][];
            for (var row = 0; row < rows; row++)
            {
                grid[row] = new int[columns];
                for (var col = 0; col < columns; col++)
                {
                    grid[row][col] = 0;
                }
            }
            return grid;
        }

        private void ApplyWallsAndGuards(int[][] guards, int[][] walls, int[][] grid)
        {
            foreach (var guard in guards)
            {
                var row = guard[0];
                var col = guard[1];
                grid[row][col] = 1;
            }

            foreach (var wall in walls)
            {

            }
        }
    }
}
