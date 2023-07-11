using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/partition-array-such-that-maximum-difference-is-k/
    /// </summary>
    public class Leetcode_2294_PartitionArraySuchThatMaximumDifferenceIsK_V1
    {
        public int CalculateMinimumSequences(int[] values, int maxDifference)
        {
            Array.Sort(values);
            var numberOfSequences = 0;
            var currentMin = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                var currentDifference = values[index] - currentMin;
                if (currentDifference > maxDifference)
                {
                    numberOfSequences++;
                    currentMin = values[index];
                }
            }
            return numberOfSequences + 1;
        }
    }
}
