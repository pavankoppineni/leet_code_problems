using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray
{
    /// <summary>
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/submissions/
    /// </summary>
    public class LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V3
    {
        private int[] _nums;
        private int _target;
        public int[] SearchRange(int[] nums, int target)
        {
            _nums = nums;
            _target = target;

            var firstIndex = FindFirst(0, nums.Length - 1, -1);
            if (firstIndex == -1)
            {
                return new int[] { -1, -1 };
            }
            var lastIndex = FindLast(firstIndex + 1, nums.Length - 1, -1);
            if (lastIndex == -1)
            {
                return new int[] { firstIndex, firstIndex };
            }
            return new int[] { firstIndex, lastIndex };
        }

        private int FindFirst(int start, int end, int index)
        {
            if (start > end)
            {
                return index;
            }

            var mid = start + (end - start) / 2;

            //Case 1 : When mid value is greater than target
            //Action : Search left half of array
            if (_nums[mid] > _target)
            {
                return FindFirst(start, mid - 1, index);
            }

            //Case 2 : When mid value is less than target
            //Action : Search right half of array
            if (_nums[mid] < _target)
            {
                return FindFirst(mid + 1, end, index);
            }

            //Case 3 : When mid value is equal to target
            return FindFirst(start, mid - 1, mid);
        }

        private int FindLast(int start, int end, int index)
        {
            if (start > end)
            {
                return index;
            }

            var mid = start + (end - start) / 2;

            //Case 1 : When mid value is greater than target
            //Action : Search left half of array
            if (_nums[mid] > _target)
            {
                return FindLast(start, mid - 1, index);
            }

            //Case 2 : When mid value is less than target
            //Action : Search right half of array
            if (_nums[mid] < _target)
            {
                return FindLast(mid + 1, end, index);
            }

            //Case 3 : When mid value is equal to target
            return FindLast(mid + 1, end, mid);
        }
    }
}
