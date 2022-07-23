using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_805_SplitArrayWithSameAverage
{
    /// <summary>
    /// https://leetcode.com/problems/split-array-with-same-average/
    /// </summary>
    public class Leetcode_805_SplitArrayWithSameAverage_V1
    {
        public bool CanSplitArrayWithSameAverage(int[] values)
        {
            var canSplit = false;
            var sum = values.Sum();
            var prefixSum = 0;
            for (var index = 0; index < values.Length - 1; index++)
            {
                prefixSum += values[index];
                var leftSide = index + 1;
                var rightSide = values.Length - leftSide;
                decimal leftAverage = prefixSum / rightSide;
                decimal rightAverage = (sum - prefixSum) / rightSide;
                if(leftAverage == rightAverage)
                {
                    canSplit = true;
                    break;
                }
            }
            return canSplit;
        }
    }
}
