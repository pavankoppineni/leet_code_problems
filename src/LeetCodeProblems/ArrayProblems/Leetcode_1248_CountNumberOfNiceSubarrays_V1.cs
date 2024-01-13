using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-number-of-nice-subarrays/
    /// </summary>
    public class Leetcode_1248_CountNumberOfNiceSubarrays_V1
    {
        public int CalculateNumberOfSubArrays(int[] values, int k)
        {
            var numberOfSubArrays  = 0;
            var lookup = new Dictionary<int, int>();
            lookup.Add(0, 1);
            var previousSum = 0;
            for (var index = 0; index < values.Length; index++)
            {
                var isOdd = (values[index] & 1) == 1;
                previousSum += isOdd ? 1 : 0;
                if (!lookup.ContainsKey(previousSum))
                {
                    lookup.Add(previousSum, 0);
                }
                lookup[previousSum]++;

                var remainingSum = previousSum - k;
                if (lookup.ContainsKey(remainingSum))
                {
                    numberOfSubArrays += lookup[remainingSum];
                }
            }
            return numberOfSubArrays;
        }
    }
}
