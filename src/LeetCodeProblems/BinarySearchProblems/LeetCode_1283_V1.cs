using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold/
    /// </summary>
    public class LeetCode_1283_V1
    {
        private int[] nums;
        private int threshold;

        public int FindSmallestDivisor(int[] nums, int threshold)
        {
            this.nums = nums;
            this.threshold = threshold;
            return FindSmallestDivisor(1, nums.Max());
        }

        private int FindSmallestDivisor(int min, int max)
        {
            if(min == max)
            {
                return min;
            }

            var mid = (min + max) >> 1;
            var currentThreshold = CalculateThreshold(mid);

            //Case 1 : Current threshold is greater than threshold
            if (currentThreshold > threshold)
            {
                return FindSmallestDivisor(mid + 1, max);
            }
            //Case 2 : Current threshold is less than or equal to threshold
            else
            {
                return FindSmallestDivisor(min, mid);
            }
        }

        private int CalculateThreshold(int divisor)
        {
            decimal sum = 0;
            foreach (var num in nums)
            {
                sum += Math.Ceiling(num / (decimal)divisor);
            }

            return (int)sum;
        }
    }
}
