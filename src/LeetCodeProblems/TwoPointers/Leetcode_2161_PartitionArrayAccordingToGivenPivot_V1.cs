using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TwoPointers
{
    /// <summary>
    /// https://leetcode.com/problems/partition-array-according-to-given-pivot
    /// </summary>
    public class Leetcode_2161_PartitionArrayAccordingToGivenPivot_V1
    {
        public int[] PivotArray(int[] nums, int pivot)
        {
            var result = new int[nums.Length];
            var leftPointer = 0;
            var rightPointer = nums.Length - 1;
            for (var index = 0; index < nums.Length; index++)
            {
                if (nums[index] < pivot)
                {
                    result[leftPointer] = nums[index];
                    leftPointer++;
                }

                if (nums[nums.Length - 1 - index] > pivot)
                {
                    result[rightPointer] = nums[nums.Length - 1 - index];
                    rightPointer--;
                }
            }

            if (leftPointer > rightPointer)
            {
                return result;
            }

            for (var index = leftPointer; index <= rightPointer; index++)
            {
                result[index] = pivot;
            }

            return result;
        }
    }
}
