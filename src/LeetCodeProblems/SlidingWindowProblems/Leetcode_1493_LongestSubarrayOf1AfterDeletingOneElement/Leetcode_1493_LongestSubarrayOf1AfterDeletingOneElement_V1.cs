using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems.Leetcode_1493_LongestSubarrayOf1AfterDeletingOneElement
{
    /// <summary>
    /// https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/
    /// </summary>
    public class Leetcode_1493_LongestSubarrayOf1AfterDeletingOneElement_V1
    {
        public int LongestSubarray(int[] nums)
        {
            var prevPosition = -1;
            var length = 0;
            var currentLength = 0;
            for (var index = 0; index < nums.Length; index++)
            {
                //Case 1 : When nums[index] is zero
                if (nums[index] == 0)
                {
                    //Case 1A : When prevposition is -1;
                    if (prevPosition == -1)
                    {
                        prevPosition = index;
                        continue;
                    }
                    else
                    {
                        currentLength = index - prevPosition - 1;
                        prevPosition = index;
                    }
                }
                //Case 2 : When nums[index] is one
                else
                {
                    currentLength += 1;
                }

                if (currentLength > length)
                {
                    length = currentLength;
                }
            }
            if (currentLength > length)
            {
                length = currentLength;
            }
            if (length == nums.Length)
            {
                return length - 1;
            }
            return length;
        }
    }
}
