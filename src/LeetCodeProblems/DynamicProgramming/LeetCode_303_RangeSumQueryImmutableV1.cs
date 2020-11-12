using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-immutable/
    /// </summary>
    public class LeetCode_303_RangeSumQueryImmutableV1
    {
        private readonly int[] nums;
        private readonly int[] prefixSum;

        public LeetCode_303_RangeSumQueryImmutableV1(int[] nums)
        {
            this.nums = nums;
            prefixSum = new int[nums.Length];
            prefixSum[0] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i];
            }
        }

        public int GetRangeSum(int left, int right)
        {
            if (left == 0)
            {
                return prefixSum[right];
            }

            return prefixSum[right] - prefixSum[left - 1];
        }
    }
}
