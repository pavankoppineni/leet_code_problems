using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_1605_FindValidMatrixGivenRowAndColumnSums
{
    /// <summary>
    /// https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums/
    /// </summary>
    public class Leetcode_1605_FindValidMatrixGivenRowAndColumnSums_V1
    {
        public int[][] ConstructMatrix(int[] rowSum, int[] columnSum)
        {
            var matrix = new int[rowSum.Length][];
            for (var rowIndex = 0; rowIndex < rowSum.Length; rowIndex++)
            {
                matrix[rowIndex] = new int[columnSum.Length];
                for (var columnIndex = 0; columnIndex < columnSum.Length; columnIndex++)
                {
                    var row = rowSum[rowIndex];
                    var column = columnSum[columnIndex];
                    matrix[rowIndex][columnIndex] = Math.Min(row, column);
                    rowSum[rowIndex] -= matrix[rowIndex][columnIndex];
                    columnSum[columnIndex] -= matrix[rowIndex][columnIndex];
                }
            }
            return matrix;
        }
    }
}
