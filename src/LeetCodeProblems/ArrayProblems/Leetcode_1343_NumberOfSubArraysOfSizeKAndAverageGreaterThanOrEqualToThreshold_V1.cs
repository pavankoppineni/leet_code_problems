using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold/
    /// </summary>
    public class Leetcode_1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOr_EqualToThreshold_V1
    {
        public int FindNumberOfSubArrays(int[] values, int subArraySize, int threshold)
        {
            var count = 0;
            var currentSum = 0;
            var index = 0;
            while(index < subArraySize)
            {
                currentSum += values[index];
                index += 1;
            }
            if (currentSum / subArraySize >= threshold)
            {
                count += 1;
            }
            while (index < values.Length)
            {
                currentSum += values[index];
                currentSum -= values[index - subArraySize];
                if (currentSum / subArraySize >= threshold)
                {
                    count += 1;
                }
                index += 1;
            }

            return count;
        }
    }
}
