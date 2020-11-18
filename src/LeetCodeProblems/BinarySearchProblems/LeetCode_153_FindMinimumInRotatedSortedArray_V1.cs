using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    /// </summary>
    public class LeetCode_153_FindMinimumInRotatedSortedArray_V1
    {
        private int[] values;
        public int FindMin(int[] values)
        {
            this.values = values;
            var pivot = FindPivot(0, this.values.Length - 1);
            return this.values[pivot];
        }

        private int FindPivot(int low, int high)
        {
            if (low == high)
            {
                return low;
            }

            var mid = (low + high) >> 1;

            //Case 1 : Mid is greater than high
            if (values[mid] > values[high])
            {
                return FindPivot(mid + 1, high);
            }

            //Case 2 : Mid is less than high
            return FindPivot(low, mid);
        }
    }
}
