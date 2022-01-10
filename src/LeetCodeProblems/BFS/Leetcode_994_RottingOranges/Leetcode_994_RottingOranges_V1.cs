using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BFS.Leetcode_994_RottingOranges
{
    /// <summary>
    /// https://leetcode.com/problems/rotting-oranges/
    /// </summary>
    public class Leetcode_994_RottingOranges_V1
    {
        private int[,] _directions;
        public Leetcode_994_RottingOranges_V1()
        {
            _directions = new int[,]
            {
                {0,1 },
                {0, -1 },
                {1, 0 },
                {-1, 0 },
            };
        }

        public int CalculateMinimumMinutesToRot(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var queue = new Queue<(int row, int col)>();
            return 0;
        }
    }
}
