using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/first-completely-painted-row-or-column/
    /// </summary>
    public class Leetcode_2661_FirstCompletelyPaintedRowOrColumn_V1
    {
        public int CalculateFirstCompleteIndex(int[] values, int[][] matrix)
        {
            var smallestIndex = -1;
            var lookup = new Dictionary<int, (int row, int col)>();
            var rowCounter = new int[matrix.Length];
            var colCounter = new int[matrix[0].Length];
            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[row].Length; col++)
                {
                    lookup.Add(matrix[row][col], (row, col));
                }
            }

            for (var index = 0; index < values.Length; index++)
            {
                var pointer = lookup[values[index]];
                rowCounter[pointer.row] += 1;
                colCounter[pointer.col] += 1;
                if (rowCounter[pointer.row] >= colCounter.Length || colCounter[pointer.col] >= rowCounter.Length)
                {
                    smallestIndex = index;
                    break;
                }
            }
            return smallestIndex;
        }
    }
}
