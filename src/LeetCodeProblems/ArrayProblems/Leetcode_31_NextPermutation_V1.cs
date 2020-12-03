using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// </summary>
    public class Leetcode_31_NextPermutation_V1
    {
        private int[] nums;

        public int[] FindNextPermutation(int[] nums)
        {
            this.nums = nums;

            var index = -1;
            var previousIndex = nums.Length - 1;
            while (previousIndex > 0)
            {
                var currentIndex = previousIndex - 1;
                if (nums[currentIndex] >= nums[previousIndex])
                {
                    previousIndex = currentIndex;
                }
                else
                {
                    index = currentIndex;
                    break;
                }
            }

            if (index == -1)
            {
                var start = 0;
                var end = nums.Length - 1;
                Reverse(start, end);
                return nums;
            }

            var permutationIndex = FindNextPermutationIndex(index + 1, nums.Length - 1, nums[index]);
            var temp = nums[index];
            nums[index] = nums[permutationIndex];
            nums[permutationIndex] = temp;
            Reverse(index + 1, nums.Length - 1);

            return nums;
        }

        private void Reverse(int start, int end)
        {
            while (start < end)
            {
                var tempStart = nums[start];
                nums[start] = nums[end];
                nums[end] = tempStart;
                start += 1;
                end -= 1;
            }
        }

        private int FindNextPermutationIndex(int startInclusive, int endInclusive, int value)
        {
            if (endInclusive - startInclusive == 1)
            {
                if (value < nums[endInclusive])
                {
                    return endInclusive;
                }
                else if (value < nums[startInclusive])
                {
                    return startInclusive;
                }
            }
            if(startInclusive == endInclusive)
            {
                return startInclusive;
            }

            var mid = (startInclusive + endInclusive) >> 1;

            //Case 1 : Value is less than mid
            if (value < nums[mid])
            {
                return FindNextPermutationIndex(mid, endInclusive, value);
            }

            // Case 2 : 
            else
            {
                return FindNextPermutationIndex(startInclusive, mid - 1, value);
            }
        }
    }
}
