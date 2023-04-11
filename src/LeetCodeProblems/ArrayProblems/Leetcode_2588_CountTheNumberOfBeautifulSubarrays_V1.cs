using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-beautiful-subarrays/
    /// </summary>
    public class Leetcode_2588_CountTheNumberOfBeautifulSubarrays_V1
    {
        public int CalculateNumberOfBeautifulSubArrays(int[] values)
        {
            var prefixLookup = new Dictionary<long, int>() { {0, 1 } };
            long previousXOR = 0;
            var countOfSubArrays = 0;
            for (var index = 0; index < values.Length; index++)
            {
                previousXOR ^= values[index];
                if (prefixLookup.ContainsKey(previousXOR))
                {
                    countOfSubArrays += prefixLookup[previousXOR];
                    prefixLookup[previousXOR]++;
                }
                else
                {
                    prefixLookup.Add(previousXOR, 1);
                }
            }
            return countOfSubArrays;
        }
    }
}
