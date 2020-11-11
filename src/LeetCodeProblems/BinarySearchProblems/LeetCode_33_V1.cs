using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public class LeetCode_33_V1
    {
        private int[] values;
        private int target;

        public int SearchElement(int[] values, int target)
        {
            this.values = values;
            this.target = target;

            var pivotIndex = FindPivot(0, values.Length - 1);

            if (pivotIndex == 0)
            {
                return SearchElement(0, values.Length - 1);
            }

            if (target >= values[0])
            {
                return SearchElement(0, pivotIndex - 1);
            }

            return SearchElement(pivotIndex, values.Length - 1);
        }

        private int SearchElement(int low, int high)
        {
            var mid = (low + high) >> 1;

            //Case 1 : Mid is equal to target
            //Action : Return mid index
            if (values[mid] == target)
            {
                return mid;
            }

            //Case 2 : Mid is greater than target
            //Action : Search left
            else if (values[mid] > target)
            {
                return SearchElement(low, mid - 1);
            }
            //Case 3 : Mid is less than target
            //Action : Search right
            else
            {
                return SearchElement(mid + 1, high);
            }
        }

        /// <summary>
        /// Method to find pivot element in sorted rotated array
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns>Return</returns>
        private int FindPivot(int low, int high)
        {
            if (low == high)
            {
                return low;
            }

            var mid = (low + high) >> 1;
            //Case 1 : Mid is less than high
            //Action : Search left
            if (values[mid] < values[high])
            {
                return FindPivot(low, mid);
            }
            //Case 2 : Mid is greater than high
            //Action : Search right
            else
            {
                return FindPivot(mid + 1, high);
            }
        }
    }
}
