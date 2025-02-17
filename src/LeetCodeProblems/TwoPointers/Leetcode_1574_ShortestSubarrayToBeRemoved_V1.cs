using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TwoPointers
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-subarray-to-be-removed-to-make-array-sorted/description
    /// </summary>
    public class Leetcode_1574_ShortestSubarrayToBeRemoved_V1
    {
        public int CalculateShortestSubArray(int[] nums)
        {
            var leftPointer = CountLeftSubArray(nums);
            if (leftPointer == nums.Length - 1)
            {
                return 0;
            }

            var rightPointer = CountRightSubArray(nums);
            if (leftPointer == 0 && rightPointer == nums.Length - 1)
            {
                return nums.Length - 1;
            }

            return CalculateShortestSubarray(nums, leftPointer, rightPointer);
        }

        private int CalculateShortestSubarray(int[] nums, int leftPointer, int rightPointer)
        {
            var currentMin = 0;
            var min = int.MaxValue;
            var leftIndex = leftPointer;
            var rightIndex = rightPointer;
            while (leftIndex >= 0 && rightIndex <= nums.Length - 1)
            {
                var left = nums[leftIndex];
                var right = nums[rightIndex];

                // Case 1
                // When : left is less than or equal to right
                // Then :
                if (left <= right)
                {
                    currentMin = rightIndex - (leftIndex + 1);
                    min = Math.Min(min, currentMin);
                    break;
                }

                if (left > right)
                {
                    min = nums.Length - leftIndex;
                    rightIndex++;
                }
            }

            return min;
        }

        private int CountLeftSubArray(int[] nums)
        {
            var pointer = 0;
            for (var index = 1; index < nums.Length; index++)
            {
                if (nums[index] >= nums[index - 1])
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
                if (nums[index] <= nums[index + 1])
                {
                    continue;
                }

                return index + 1;
            }

            return nums.Length - 1;
        }
    }
}
