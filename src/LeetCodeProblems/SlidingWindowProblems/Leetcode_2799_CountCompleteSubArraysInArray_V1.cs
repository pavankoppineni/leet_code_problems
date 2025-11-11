using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-complete-subarrays-in-an-array/description/?envType=problem-list-v2&envId=sliding-window
    /// </summary>
    public class Leetcode_2799_CountCompleteSubArraysInArray_V1
    {
        public int Calculate(int[] values)
        {
            var numberOfSubarrays = 0;
            var distinctCount = GetDistinctCount(values);
            var lookup = new Dictionary<int, int>();
            var left = 0;
            var right = 0;
            for (; right < values.Length;)
            {
                var value = values[right];
                if (lookup.ContainsKey(value))
                {
                    lookup[value] += 1;
                    right++;
                    continue;
                }

                lookup.Add(value, 1);

                // When : lookup count is less than distinct count
                if (lookup.Count < distinctCount)
                {
                    right++;
                    continue;
                }

                // When : lookup count is equal to distinct count
                while (lookup.Count == distinctCount)
                {
                    numberOfSubarrays += values.Length - right;
                    var leftValue = values[left];
                    lookup[leftValue] -= 1;
                    if (lookup[leftValue] == 0)
                    {
                        lookup.Remove(leftValue);
                    }
                    left++;
                }

                right++;
            }

            return numberOfSubarrays;
        }

        private int GetDistinctCount(int[] values)
        {
            var lookup = new HashSet<int>();
            foreach (var value in values)
            {
                lookup.Add(value);
            }

            return lookup.Count;
        }
    }
}
