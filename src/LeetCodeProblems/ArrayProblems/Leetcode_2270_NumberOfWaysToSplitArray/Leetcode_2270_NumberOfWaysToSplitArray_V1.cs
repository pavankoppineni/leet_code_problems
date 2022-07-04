using System;
using System.Collections.Generic;
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
            var prefixArray = new long[values.Length];
            prefixArray[0] = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                prefixArray[index] = values[index] + prefixArray[index - 1];
            }

            for (var index = 0; index < prefixArray.Length - 1; index++)
            {
                var leftSum = prefixArray[index];
                var rightSum = prefixArray[values.Length - 1] - leftSum;
                if (leftSum >= rightSum)
                {
                    numberofWays += 1;
                }
            }
            return numberofWays;
        }
    }
}
