using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public class Leetcode_53_MaximumSubArray_V1
    {
        public int FindMaximumSum(int[] values)
        {
            var localSum = 0;
            var globaSum = int.MinValue;
            for (var index = 0; index < values.Length; index++)
            {
                localSum = Math.Min(values[index], values[index] + localSum);
                if (localSum > globaSum)
                {
                    globaSum = localSum;
                }
            }

            return globaSum;
        }
    }
}
