using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-2d-immutable/
    /// </summary>
    public class LeetCode_304_RangeSumQuery2DImmutableV1
    {
        private readonly int[][] matrix;
        private readonly int[][] prefixSumMatrix;
        private readonly int length;
        private readonly int rowLength;
        private readonly int columnLength;

        public LeetCode_304_RangeSumQuery2DImmutableV1(int[][] matrix)
        {
            length = matrix.Length;
            if (length > 0)
            {
                this.matrix = matrix;
                rowLength = this.matrix.GetLength(0);
                columnLength = this.matrix[0].Length;
                prefixSumMatrix = new int[rowLength][];
                CalculatePrefixSum();
            }
        }

        public int GetRangeSum(int startRow, int endRow, int startColumn, int endColumn)
        {
            if (startRow < 0 || startColumn < 0)
            {
                return 0;
            }

            if (endRow >= rowLength || endColumn >= columnLength)
            {
                return 0;
            }

            return GetSumFromLookUp(endRow, endColumn)
                - GetSumFromLookUp(startRow - 1, endColumn)
                - (GetSumFromLookUp(endRow, startColumn - 1) - GetSumFromLookUp(startRow - 1, startColumn - 1));
        }

        private void CalculatePrefixSum()
        {
            for (var row = 0; row < rowLength; row++)
            {
                prefixSumMatrix[row] = new int[columnLength];
                var row_sum = 0;
                for (var col = 0; col < columnLength; col++)
                {
                    row_sum += matrix[row][col];
                    prefixSumMatrix[row][col] = row_sum + GetSumFromLookUp(row - 1, col);
                }
            }
        }

        private int GetSumFromLookUp(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return 0;
            }

            if (row >= rowLength || col >= columnLength)
            {
                return 0;
            }

            return prefixSumMatrix[row][col];
        }        
    }
}
