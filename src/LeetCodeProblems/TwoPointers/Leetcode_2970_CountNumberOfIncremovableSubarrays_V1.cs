using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TwoPointers
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-incremovable-subarrays-i/description/
    /// </summary>
    public class Leetcode_2970_CountNumberOfIncremovableSubarrays_V1
    {
        public int CalculateSubArrayCount(int[] nums)
        {
            var leftPointer = CountLeftSubArray(nums);
            if (leftPointer == nums.Length - 1)
            {
                var numerator = nums.Length * (nums.Length - 1);
                var denominator = 2;
                return numerator / denominator;
            }

            var rightPointer = CountRightSubArray(nums);
            var count = CalculateSubArrayCount(leftPointer, rightPointer, nums);
            return count + leftPointer + 1 + nums.Length - rightPointer + 1;
        }

        private int CalculateSubArrayCount(int leftPointer, int rightPointer, int[] nums)
        {
            var count = 0;
            var leftIndex = 0;
            var rightIndex = rightPointer;
            while (leftIndex <= leftPointer && rightIndex <= nums.Length - 1)
            {
                if (nums[leftIndex] < nums[rightIndex])
                {
                    count += nums.Length - rightIndex;
                    leftIndex++;
                    continue;
                }

                if (nums[leftIndex] > nums[rightIndex])
                {
                    rightIndex++;
                    continue;
                }

                if (nums[leftIndex] == nums[rightIndex])
                {
                    rightIndex++;
                }
            }

            return count;
        }

        private int CountLeftSubArray(int[] nums)
        {
            var pointer = 0;
            for (var index = 1; index < nums.Length; index++)
            {
                if (nums[index] > nums[index - 1])
                {
                    pointer = index;
                    continue;
                }

                return pointer;
            }

            return pointer;
        }

        private int CountRightSubArray(int[] nums)
        {
            for (var index = nums.Length - 2; index >= 0; index--)
            {
                if (nums[index] < nums[index + 1])
                {
                    continue;
                }

                return index + 1;
            }

            return nums.Length - 1;
        }
    }
}
