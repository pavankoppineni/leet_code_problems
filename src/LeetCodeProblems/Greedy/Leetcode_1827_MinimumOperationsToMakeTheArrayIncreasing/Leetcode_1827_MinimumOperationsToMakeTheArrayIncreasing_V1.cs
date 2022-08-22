using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_1827_MinimumOperationsToMakeTheArrayIncreasing
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-make-the-array-increasing/
    /// </summary>
    public class Leetcode_1827_MinimumOperationsToMakeTheArrayIncreasing_V1
    {
        public int CalculateMinimumOperations(int[] values)
        {
            if (values.Length == 1)
            {
                return 0;
            }

            var numberOfOperations = 0;
            for (var index = 1; index < values.Length; index++)
            {
                if (values[index] > values[index - 1])
                {
                    continue;
                }

                var diff = values[index - 1] - values[index] + 1;
                numberOfOperations += diff;
                values[index] += diff;
            }
            return numberOfOperations;
        }
    }
}
