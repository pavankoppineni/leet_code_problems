using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-erasure-value/
    /// </summary>
    public class Leetcode_1695_MaximumErasureValue_V1
    {
        public int FindMaximumUniqueSubarray(int[] values)
        {
            var maxSum = 0;
            var currentSum = 0;
            var dict = new Dictionary<int, int>();
            for (var index = 0; index < values.Length; index++)
            {
                //Case A : When value is present in dictionary
                //Action : Remove value from dictionary and update sum
                if (dict.ContainsKey(values[index]))
                {

                }
                //Case B : When value is not present in dictionary
                //Action : Add value to dictionary and update sum
                else
                {
                    dict.Add(values[index], index);
                    currentSum += values[index];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            return maxSum;
        }
    }
}
