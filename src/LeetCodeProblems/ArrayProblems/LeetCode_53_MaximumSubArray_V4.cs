using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public class LeetCode_53_MaximumSubArray_V4
    {
        public int FindMaxSubArray(int[] values)
        {
            var maxSum = values[0];
            var currentMaxSum = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                currentMaxSum += values[index];
                if (Math.Max(currentMaxSum, values[index]) > maxSum)
                {
                    maxSum = Math.Max(currentMaxSum, values[index]);
                }

                if (currentMaxSum < 0)
                {
                    currentMaxSum = 0;
                }
            }
            return maxSum;
        }
    }
}
