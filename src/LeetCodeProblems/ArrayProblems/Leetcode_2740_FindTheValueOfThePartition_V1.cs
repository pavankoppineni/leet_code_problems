using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-value-of-the-partition
    /// </summary>
    public class Leetcode_2740_FindTheValueOfThePartition_V1
    {
        public int CalculateMinimumPartition(int[] values)
        {
            Array.Sort(values);
            var minimumPartition = Math.Abs(values[0] - values[1]);
            for (var index = 1; index < values.Length; index++)
            {
                var currentParition = Math.Abs(values[index] - values[index - 1]);
                minimumPartition = Math.Min(minimumPartition, currentParition);
            }
            return minimumPartition;
        }
    }
}
