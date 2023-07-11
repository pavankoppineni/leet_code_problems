using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-moves-in-a-grid/
    /// </summary>
    public class Leetcode_2684_MaximumNumberOfMovesInGrid_V1
    {
        public int CalculateMaximumMoves(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var maxMoves = 0;
            for (var index = cols - 1; index >= 0; index--)
            {
            }
            return maxMoves;
        }
    }
}
