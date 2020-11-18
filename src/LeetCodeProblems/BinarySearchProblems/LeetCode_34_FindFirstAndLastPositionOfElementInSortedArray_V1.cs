using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    public class LeetCode_34_FindFirstAndLastPositionOfElementInSortedArray_V1
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var positions = new int[2];
            var positionTuple = Search(nums, 0, nums.Length - 1, target);
            positions[0] = positionTuple.i;
            positions[1] = positionTuple.j;

            return positions;
        }

        private (int i, int j) Search(int[] nums, int start, int end, int target)
        {
            if (start > end)
            {
                return (-1, -1);
            }

            var mid = (start + end) / 2;
            if (nums[mid] == target)
            {
                var leftMid = mid - 1;
                var rightMid = mid + 1;

                while (leftMid >= start)
                {
                    if (nums[leftMid] == target)
                    {
                        leftMid -= 1;
                    }
                    else
                    {
                        break;
                    }
                }

                while (rightMid <= end)
                {
                    if (nums[rightMid] == target)
                    {
                        rightMid += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                return (leftMid + 1, rightMid - 1);
            }
            else if (nums[mid] > target)
            {
                return Search(nums, start, mid - 1, target);
            }
            else
            {
                return Search(nums, mid + 1, end, target);
            }
        }
    }
}
