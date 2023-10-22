using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/count-fertile-pyramids-in-a-land/
    /// </summary>
    public class Leetcode_2088_CountFertilePyramidsInLand_V1
    {
        private IDictionary<(int row, int col), (int val, int height)> _lookup;
        private int _rowCount;
        private int _columnCount;
        private int[][] _grid;
        private int[][] _downDirections;
        public int CalculateNumberOfPyramids(int[][] grid)
        {
            throw new NotImplementedException();
        }
    }
}
