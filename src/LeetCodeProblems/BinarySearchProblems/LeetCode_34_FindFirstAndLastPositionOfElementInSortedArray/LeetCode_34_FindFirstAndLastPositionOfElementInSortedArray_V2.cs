using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    public class LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V2
    {
        public int[] SearchRange(int[] values, int target)
        {
            var index = FindIndex(values, 0, values.Length - 1, target);
            if (index == -1)
            {
                return new int[] { -1, -1 };
            }
            return GetRange(values, target, index);
        }

        private int[] GetRange(int[] values, int target, int index)
        {
            var leftIndex = index;
            var rightIndex = index;
            while (leftIndex >= 0)
            {
                if (values[leftIndex] == target)
                {
                    leftIndex -= 1;
                }
                else
                {
                    break;
                }
            }

            while (rightIndex < values.Length)
            {
                if (values[rightIndex] == target)
                {
                    rightIndex += 1;
                }
                else
                {
                    break;
                }
            }

            return new int[] { leftIndex + 1, rightIndex - 1 };
        }

        private int FindIndex(int[] values, int start, int end, int target)
        {
            if (start > end)
            {
                return -1;
            }
            var mid = start + ((end - start) >> 1);
            var value = values[mid];

            //Case 1 : When value is equal to target
            //Action : Return mid index
            if (target == value)
            {
                return mid;
            }

            //Case 2 : When value is greater than target
            //Action : Search left side of array
            if (value > target)
            {
                return FindIndex(values, start, mid - 1, target);
            }

            //Case 3 : When value is less than target
            //Action : Search left side of array
            return FindIndex(values, mid + 1, end, target);
        }
    }
}
