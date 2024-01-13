using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-operations-to-make-array-xor-equal-to-k/
    /// </summary>
    public class Leetcode_2997_MinimumNumberOfOperationsToMakeArrayXOREqualToK_V1
    {
        public int CalculateMinOperations(int[] nums, int k)
        {
            var xorResult = 0;
            for (var index = 0; index < nums.Length; index++)
            {
                xorResult ^= nums[index];
            }
            var max = Math.Max(xorResult, k);
            var minOperations = 0;
            var position = 0;
            while ((1 << position) <= max)
            {
                var resultBit = 1 << position & xorResult;
                var kBit = 1 << position & k;
                if (resultBit != kBit)
                {
                    minOperations += 1;
                }
                position += 1;
            }
            return minOperations;
        }
    }
}
