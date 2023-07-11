using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/longest-non-decreasing-subarray-from-two-arrays/
    /// </summary>
    public class Leetcode_2771_LongestNonDecreasingSubarrayFromTwoArrays_V1
    {
        public int CalculateMaxLengthOfIncreasingSubArray(int[] arrayOne, int[] arrayTwo)
        {
            var length = arrayOne.Length;
            var maxLength = 1;
            var previousArrayItem = new ArrayItem((arrayOne[length - 1], 1), (arrayTwo[length - 1], 1));
            for (var index = length - 2; index >= 0; index--)
            {
                var valueTupleOne = CalculateLength(arrayOne[index], previousArrayItem);
                var valueTupleTwo = CalculateLength(arrayTwo[index], previousArrayItem);
                previousArrayItem = new ArrayItem(valueTupleOne, valueTupleTwo);
                var currentMax = Math.Max(valueTupleOne.length, valueTupleTwo.length);
                maxLength = Math.Max(maxLength, currentMax);
            }
            return maxLength;
        }

        private (int value, int length) CalculateLength(int value, ArrayItem previousItem)
        {
            var itemOne = previousItem.ItemOne;
            var itemTwo = previousItem.ItemTwo;

            //When : Value is greater than previous values
            if (value > itemOne.value && value > itemTwo.value)
            {
                return (value, 1);
            }

            //When : Value is less than previous values                                                                                                                                                                                    
            if (value <= itemOne.value && value <= itemTwo.value)
            {
                return (value, Math.Max(itemOne.length, itemTwo.length) + 1);
            }

            //When : Value is greater than previous value one and less than or equal to previous value two
            if (value > itemOne.value)
            {
                return (value, itemTwo.length + 1);
            }

            //When : Value is greater than previous value two and less than or equal to previous value one
            return (value, itemOne.length + 1);
        }
    }

    public class ArrayItem
    {
        public ArrayItem((int value, int length) itemOne, (int value, int length) itemTwo)
        {
            ItemOne = itemOne;
            ItemTwo = itemTwo;
        }
        public (int value, int length) ItemOne { get; set; }
        public (int value, int length) ItemTwo { get; set; }
    }
}
