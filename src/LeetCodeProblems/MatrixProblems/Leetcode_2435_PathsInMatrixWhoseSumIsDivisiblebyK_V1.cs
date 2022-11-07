using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/paths-in-matrix-whose-sum-is-divisible-by-k/
    /// </summary>
    public class Leetcode_2435_PathsInMatrixWhoseSumIsDivisiblebyK_V1
    {
        private int[][] _grid;
        private int _columns;
        private int _rows;
        private int _denominator;
        public int CalculateNumberOfPaths(int[][] grid, int k)
        {
            _denominator = k;
            _grid = grid;
            _rows = grid.Length;
            _columns = grid[0].Length;
            return CalculatePath(0, 0, 0);
        }

        private int CalculatePath(int x, int y, int sum)
        {
            if (x >= _rows || y >= _columns)
            {
                return 0;
            }

            if (x == _rows - 1 && y == _columns - 1)
            {
                sum += _grid[x][y];
                if (sum % _denominator == 0)
                {
                    return 1;
                }
                return 0;
            }

            var rightDirection = CalculatePath(x, y + 1, sum + _grid[x][y]);
            var downDirection = CalculatePath(x + 1, y, sum + _grid[x][y]);
            return rightDirection + downDirection;
        }
    }
}
