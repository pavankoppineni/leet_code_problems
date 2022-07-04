using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2270_NumberOfWaysToSplitArray
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-ways-to-split-array/
    /// </summary>
    public class Leetcode_2270_NumberOfWaysToSplitArray_V1
    {
        public int CalculateNumberOfWays(int[] values)
        {
            var numberofWays = 0;
            long totalSum = 0;
            for (var index = 0; index < values.Length; index++)
            {
                totalSum += values[index];
            }

            long leftSum = 0;
            for (var index = 0; index < values.Length - 1; index++)
            {
                leftSum += values[index];
                long rightSum = totalSum - leftSum;
                if (leftSum >= rightSum)
                {
                    numberofWays += 1;
                }
            }
            return numberofWays;
        }
    }
}
