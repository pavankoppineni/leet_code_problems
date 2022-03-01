using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_26_RemoveDuplicatesFromSortedArray
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class Leetcode_26_RemoveDuplicatesFromSortedArray_V1
    {
        public int RemoveDuplicates(int[] nums)
        {
            var currentPosition = 0;
            var leftPointer = 0;
            var rightPointer = 0;
            while (rightPointer < nums.Length)
            {
                if (nums[rightPointer] == nums[leftPointer])
                {
                    rightPointer++;
                }
                else
                {
                    nums[currentPosition] = nums[leftPointer];
                    currentPosition++;
                    leftPointer = rightPointer;
                }
            }
            nums[currentPosition] = nums[leftPointer];
            return currentPosition + 1;
        }
    }
}
