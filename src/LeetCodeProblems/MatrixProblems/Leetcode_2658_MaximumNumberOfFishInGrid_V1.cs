using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-fish-in-a-grid/
    /// </summary>
    public class Leetcode_2658_MaximumNumberOfFishInGrid_V1
    {
        private int[][] _directions;
        private bool[,] _visited;
        private int _maximumFish;
        private int[][] _gird;
        private int _rows;
        private int _columns;
        public int CalculateMaximumNumberOfFish(int[][] grid)
        {
            return _maximumFish;
        }

        private void CalculateMaximumNumberOfFish(int row, int column)
        {
        }
    }
}
