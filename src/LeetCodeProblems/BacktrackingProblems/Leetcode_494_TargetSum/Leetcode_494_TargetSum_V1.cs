using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_494_TargetSum
{
    /// <summary>
    /// https://leetcode.com/problems/target-sum/
    /// </summary>
    public class Leetcode_494_TargetSum_V1
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            return FindTargetSumWays(nums, target, 0);
        }

        private int FindTargetSumWays(int[] nums, int target, int level)
        {
            if (level >= nums.Length)
            {
                if (target == 0)
                {
                    return 1;
                }
                return 0;
            }

            var left = FindTargetSumWays(nums, target + nums[level], level + 1);
            var right = FindTargetSumWays(nums, target - nums[level], level + 1);
            return left + right;
        }
    }
}
