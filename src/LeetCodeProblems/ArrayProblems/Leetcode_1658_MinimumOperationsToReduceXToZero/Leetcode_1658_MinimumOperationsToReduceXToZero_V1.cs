using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1658_MinimumOperationsToReduceXToZero
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/
    /// </summary>
    public class Leetcode_1658_MinimumOperationsToReduceXToZero_V1
    {
        public int CalcualteMinimumNumberOfOperations(int[] values, int number)
        {
            var prefixSumArray = new int[values.Length];
            prefixSumArray[0] = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                prefixSumArray[index] = prefixSumArray[index - 1] + values[index];
            }
            var sum = prefixSumArray[values.Length - 1];
            var remainingSum = 6;
            var lookup = new Dictionary<int, int>();
            for (var index = 0; index < values.Length; index++)
            {
                var prefixSum = prefixSumArray[index];
                lookup.Add(prefixSum, index);
                if (lookup.ContainsKey(prefixSum - remainingSum))
                {
                }
            }
            return 0;
        }
    }
}
