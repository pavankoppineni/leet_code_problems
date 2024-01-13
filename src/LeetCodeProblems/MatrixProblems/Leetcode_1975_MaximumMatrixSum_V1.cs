using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-matrix-sum/
    /// </summary>
    public class Leetcode_1975_MaximumMatrixSum_V1
    {
        public int CalculateSum(int[][] matrix)
        {
            var min = int.MaxValue;
            var negativeCount = 0;
            var sum = 0;
            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[0].Length; col++)
                {
                    var value = matrix[row][col];
                    if (value < 0)
                    {
                        negativeCount++;
                    }
                    var absValue = Math.Abs(value);
                    min = Math.Min(min, absValue);
                    sum += absValue;
                }
            }
            if (negativeCount % 2 == 0)
            {
                return sum;
            }
            return sum - min;
        }
    }
}
