using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/continuous-subarray-sum/
    /// </summary>
    public class Leetcode_523_ContinuousSubarraySum_V1
    {
        public bool CheckSubArraySum(int[] values, int k)
        {
            var prefixSum = new int[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                values[index] = values[index] % k;
            }
            for (var index = 1; index < values.Length; index++)
            {
                prefixSum[index] = prefixSum[index] + prefixSum[index - 1];
            }

            return false;
        }
    }
}
