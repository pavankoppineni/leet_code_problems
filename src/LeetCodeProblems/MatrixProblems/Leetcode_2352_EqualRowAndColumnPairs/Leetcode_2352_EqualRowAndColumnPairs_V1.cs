using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_2352_EqualRowAndColumnPairs
{
    /// <summary>
    /// https://leetcode.com/problems/equal-row-and-column-pairs/
    /// </summary>
    public class Leetcode_2352_EqualRowAndColumnPairs_V1
    {
        public int CalculateEqualPairs(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var sumLookup = new Dictionary<string, Pair>();
            for (var row = 0; row < rows; row++)
            {
                var currentRowHash = string.Empty;
                for (var col = 0; col < cols; col++)
                {
                    currentRowHash = $"{currentRowHash}_{grid[row][col]}";
                }
                if (!sumLookup.ContainsKey(currentRowHash))
                {
                    sumLookup.Add(currentRowHash, new Pair());
                }
                sumLookup[currentRowHash].RowCount += 1;
            }

            for (var col = 0; col < cols; col++)
            {
                var currentColumnHash = string.Empty;
                for (var row = 0; row < rows; row++)
                {
                    currentColumnHash = $"{currentColumnHash}_{grid[row][col]}";
                }
                if (!sumLookup.ContainsKey(currentColumnHash))
                {
                    sumLookup.Add(currentColumnHash, new Pair());
                }
                sumLookup[currentColumnHash].ColCount += 1;
            }

            var numberOfPairs = 0;
            foreach (var pair in sumLookup)
            {
                numberOfPairs += pair.Value.CalculatePairs();
            }
            return numberOfPairs;
        }

        public class Pair
        {
            public int ColCount { get; set; }
            public int RowCount { get; set; }

            public int CalculatePairs()
            {
                return ColCount * RowCount;
            }
        }
    }
}
