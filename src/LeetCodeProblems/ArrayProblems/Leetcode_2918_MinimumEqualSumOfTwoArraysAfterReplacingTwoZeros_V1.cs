using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-equal-sum-of-two-arrays-after-replacing-zeros/
    /// </summary>
    public class Leetcode_2918_MinimumEqualSumOfTwoArraysAfterReplacingTwoZeros_V1
    {
        public int CalculateMinimumSum(int[] nums1, int[] nums2)
        {
            throw new NotImplementedException();
        }

        private (int sum, int zeroCount) Process(int[] nums)
        {
            var sum = 0;
            var zeroCount = 0;
            foreach(int i in nums)
            {
                if (i == 0)
                {
                    zeroCount++;
                    continue;
                }
                sum += i;
            }
            return (sum, zeroCount);
        }
    }
}
