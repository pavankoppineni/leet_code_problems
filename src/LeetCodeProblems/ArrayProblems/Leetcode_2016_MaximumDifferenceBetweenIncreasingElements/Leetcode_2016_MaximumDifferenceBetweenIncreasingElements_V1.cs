using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2016_MaximumDifferenceBetweenIncreasingElements
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-difference-between-increasing-elements/
    /// </summary>
    public class Leetcode_2016_MaximumDifferenceBetweenIncreasingElements_V1
    {
        public int CalculateMaximumDifference(int[] nums)
        {
            int maxDifference = 0;
            var min = nums[0];
            for (var index = 1; index < nums.Length; index++)
            {
                if (nums[index] < min)
                {
                    min = nums[index];
                    continue;
                }
                var currentDifference = nums[index] - min;
                maxDifference = Math.Max(maxDifference, currentDifference);
            }
            return maxDifference <= 0 ? -1 : maxDifference;
        }
    }
}
