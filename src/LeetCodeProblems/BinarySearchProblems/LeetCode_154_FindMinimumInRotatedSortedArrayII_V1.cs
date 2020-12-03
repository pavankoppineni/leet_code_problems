using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
    /// </summary>
    public class LeetCode_154_FindMinimumInRotatedSortedArrayII_V1
    {
        private int[] nums;
        public int FindMinimum(int[] nums)
        {
            this.nums = nums;
            return FindMinimum(0, nums.Length - 1);
        }

        private int FindMinimum(int low, int high)
        {
            if (low == high)
            {
                return nums[low];
            }

            var mid = (low + high) >> 1;

            //Case 1 : Mid is greater than high
            //Action : Search right
            if (nums[mid] > nums[high])
            {
                return FindMinimum(mid + 1, high);
            }
            //Case 2 : Mid is less than high
            //Action : Search left
            else if (nums[mid] < nums[high])
            {
                return FindMinimum(low, mid);
            }
            //Case 3 : Mid is equal to high
            //Action : Search Right and Left
            else
            {
                var rightNum = FindMinimum(mid + 1, high);
                var leftNum = FindMinimum(low, mid - 1);
                return Math.Min(rightNum, leftNum);
            }
        }
    }
}
