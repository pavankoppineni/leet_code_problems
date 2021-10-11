using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.RemoveArrayEndElementToMaximizeSumOfProduct
{
    /// <summary>
    /// https://www.geeksforgeeks.org/remove-array-end-element-maximize-sum-product/
    /// </summary>
    public class RemoveArrayEndElementToMaximizeSumOfProduct_V2
    {
        private int[,] _dp;
        public int FindMaximumSum(int[] values)
        {
            _dp = new int[values.Length, values.Length];
            var maxResult = FindMaximumSum(values, 0, values.Length - 1, 1);
            return maxResult;
        }

        private int FindMaximumSum(int[] values, int start, int end, int rank)
        {
            if (start == end)
            {
                return values[start] * rank;
            }
            if (_dp[start, end] > 0)
            {
                return _dp[start, end];
            }
            _dp[start, end] = Math.Max(values[start] * rank + FindMaximumSum(values, start + 1, end, rank + 1), values[end] * rank + FindMaximumSum(values, start, end - 1, rank + 1));
            return _dp[start, end];
        }
    }
}
