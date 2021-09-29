using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/subarray-sum-equals-k/
    /// </summary>
    public class Leetcode_560_SubarraySumEqualsK_V2
    {
        public int FintTotalSubArrayCount(int[] values, int sum)
        {
            var prefixSum = new int[values.Length];
            var prefixSumHashSet = new Dictionary<int, IList<int>>();
            var subArrayCount = 0;
            prefixSum[0] = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                prefixSum[index] = values[index] + prefixSum[index - 1];
            }

            for (var index = 0; index < values.Length; index++)
            {
                if (prefixSumHashSet.ContainsKey(prefixSum[index]))
                {
                    prefixSumHashSet[prefixSum[index]].Add(index);
                }
                else
                {
                    prefixSumHashSet.Add(prefixSum[index], new List<int> { index });
                }
            }

            for (var index = 0; index < prefixSum.Length; index++)
            {
                var value = prefixSum[index];
                var valueWithoutSum = value - sum;
                if (prefixSumHashSet.ContainsKey(valueWithoutSum))
                {
                    subArrayCount += prefixSumHashSet[valueWithoutSum].Count;
                }
            }

            return subArrayCount;
        }
    }
}
