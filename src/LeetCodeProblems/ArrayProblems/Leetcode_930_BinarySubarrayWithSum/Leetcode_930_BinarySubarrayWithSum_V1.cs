using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_930_BinarySubarrayWithSum
{
    /// <summary>
    /// https://leetcode.com/problems/binary-subarrays-with-sum/
    /// </summary>
    public class Leetcode_930_BinarySubarrayWithSum_V1
    {
        public int CalculateCountOfSubarrays(int[] values, int target)
        {
            var lookup = new Dictionary<int, int>();
            var count = 0;
            var prefixSum = 0;
            for (var index = 0; index < values.Length; index++)
            {
                prefixSum += values[index];
                var remaining = prefixSum - target;
                if (lookup.ContainsKey(remaining))
                {
                    count += lookup[remaining];
                }
            }
            return count;
        }
    }
}
