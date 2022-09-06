using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_1292_MaximumSideLengthOfSquareWithSumLessThanOrEqualToThreshold
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-side-length-of-a-square-with-sum-less-than-or-equal-to-threshold/
    /// </summary>
    public class Leetcode_1292_MaximumSideLengthOfSquareWithSumLessThanOrEqualToThreshold_V1
    {
        private int[,] _prefixSum;
        private int _threshold;
        public int CalculateMaximumSideLength(int[][] matrix, int threshold)
        {
            _threshold = threshold;
            _prefixSum = ConstructPrefixSum(matrix);
            return 0;
        }

        private int FindSquareMatrix(int start, int end)
        {
            if (start == end)
            {
                return start;
            }

            if (start > end)
            {
                return -1;
            }

            var mid = start + ((end - start) / 2);
            return 0;
        }

        private int[,] ConstructPrefixSum(int[][] matrix)
        {
            var prefixSum = new int[matrix.Length, matrix[0].Length];
            var rowCount = matrix.Length;
            var colCount = matrix[0].Length;
            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        prefixSum[row, col] = matrix[row][col];
                        continue;
                    }

                    if (row == 0)
                    {
                        prefixSum[row, col] = matrix[row][col] + prefixSum[row, col - 1];
                        continue;
                    }

                    if (col == 0)
                    {
                        prefixSum[row, col] = matrix[row][col] + prefixSum[row - 1, col];
                        continue;
                    }
                    prefixSum[row, col] = matrix[row][col] + prefixSum[row - 1, col] + prefixSum[row, col - 1] - prefixSum[row - 1, col - 1];
                }
            }
            return prefixSum;
        }
    }
}
