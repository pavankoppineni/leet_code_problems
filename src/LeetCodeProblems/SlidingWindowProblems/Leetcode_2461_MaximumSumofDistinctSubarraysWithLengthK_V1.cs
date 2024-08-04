using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-of-distinct-subarrays-with-length-k/
    /// </summary>
    public class Leetcode_2461_MaximumSumofDistinctSubarraysWithLengthK_V1
    {
        public int CalculateSubArraySum(int[] values, int size)
        {
            var maxSum = 0;
            var prefixSum = 0;
            var lookup = new Dictionary<int, int>();
            for (var index = 0; index < size; index++)
            {
                var value = values[index];
                prefixSum += value;
                if (!lookup.ContainsKey(value))
                {
                    lookup.Add(value, 1);
                    continue;
                }
                lookup[value]++;
            }

            if (lookup.Count == size)
            {
                maxSum = prefixSum;
            }

            var startIndex = 0;
            for (var endIndex = size; endIndex < values.Length; endIndex++)
            {
                var startValue = values[startIndex];
                var value = values[endIndex];
                prefixSum += value;
                prefixSum -= startValue;
                AddAndRemoveValueFromLookup(lookup, value, startValue);
                if (lookup.Count == size)
                {
                    maxSum = Math.Max(prefixSum, maxSum);
                }
                startIndex += 1;
            }
            return maxSum;
        }

        private IDictionary<int, int> AddAndRemoveValueFromLookup(IDictionary<int, int> countLookup, int valueToAdd, int valueToRemove)
        {
            if (!countLookup.ContainsKey(valueToAdd))
            {
                countLookup.Add(valueToAdd, 1);
            }
            else
            {
                countLookup[valueToAdd]++;
            }

            if (countLookup[valueToRemove] == 1)
            {
                countLookup.Remove(valueToRemove);
                return countLookup;
            }

            countLookup[valueToRemove] -= 1;
            return countLookup;
        }
    }
}
