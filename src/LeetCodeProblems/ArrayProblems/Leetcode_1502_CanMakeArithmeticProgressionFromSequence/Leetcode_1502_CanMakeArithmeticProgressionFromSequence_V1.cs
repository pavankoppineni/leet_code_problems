using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1502_CanMakeArithmeticProgressionFromSequence
{
    /// <summary>
    /// https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/
    /// </summary>
    public class Leetcode_1502_CanMakeArithmeticProgressionFromSequence_V1
    {
        public bool IsArithmeticSeries(int[] nums)
        {
            var isArithmeticSeries = true;
            Array.Sort(nums);
            var diff = nums[1] - nums[0];
            for (var i = 2; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] != diff)
                {
                    isArithmeticSeries = false;
                    break;
                }
            }
            return isArithmeticSeries;
        }
    }
}
