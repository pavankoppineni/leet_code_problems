using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/single-element-in-a-sorted-array/
    /// </summary>
    public class Leetcode_540_SingleElementInASortedArray_V1
    {
        public int FindSingleElement(int[] values)
        {
            return FindSingleElement(values, 0, values.Length - 1);
        }

        private int FindSingleElement(int[] values, int start, int end)
        {
            if (start >= end)
            {
                return values[start];
            }

            var midIndex = ((end - start) >> 1) + start;

            //Case 1 : Min index is even
            if ((midIndex & 1) == 0)
            {
                //Case 1A : When midIndex and midIndex + 1 is equal
                //Action : Search right half
                if (values[midIndex] == values[midIndex + 1])
                {
                    return FindSingleElement(values, midIndex, end);
                }
                //Case 1A : When midIndex and midIndex - 1 is equal
                //Action : Search left half
                if (values[midIndex] == values[midIndex - 1])
                {
                    return FindSingleElement(values, start, midIndex);
                }
                return values[midIndex];
            }
            else
            {
                if (values[midIndex] == values[midIndex + 1])
                {
                    return FindSingleElement(values, start, midIndex - 1);
                }
                if (values[midIndex] == values[midIndex - 1])
                {
                    return FindSingleElement(values, midIndex + 1, end);
                }
                return values[midIndex];
            }
        }
    }
}
