using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/longest-subarray-with-maximum-bitwise-and/
    /// </summary>
    public class Leetcode_2419_LongestSubarrayWithMaximumBitwiseAND_V1
    {
        public int CalculateMaximumLength(int[] values)
        {
            if(values.Length == 1)
            {
                return 1;
            }
            var maxValue = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                maxValue = Math.Max(maxValue, values[index]);
            }

            var maxLength = 0;
            var currentLength = 0;
            for (var index = 0; index < values.Length; index++)
            {
                if (values[index] == maxValue)
                {
                    currentLength += 1;
                }
                else
                {
                    currentLength = 0;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            return maxLength;
        }
    }
}
