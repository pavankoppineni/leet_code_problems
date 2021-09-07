using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// </summary>
    public class Leetcode_4_MedianOfTwoSortedArrays_V1
    {
        public double FindMedian(int[] arrayOne, int[] arrayTwo)
        {
            return FindMedian(arrayOne, arrayTwo, 0, arrayOne.Length - 1, 0, arrayTwo.Length - 1);
        }

        private double FindMedian(int[] arrayOne, int[] arrayTwo, int startOne, int endOne, int startTwo, int endTwo)
        {
            if (endOne - startOne == 1)
            {
                var max = Math.Max(arrayOne[startOne], arrayTwo[startTwo]);
                var min = Math.Min(arrayOne[endOne], arrayTwo[endTwo]);
                return (max + min) / 2.0;
            }

            var midOne = startOne + ((endOne - startOne) >> 1);
            var midTwo = startTwo + ((endTwo - startTwo) >> 1);

            //Case 1 : midOne is greater than midTwo
            if (arrayOne[midOne] > arrayTwo[midTwo])
            {
                return FindMedian(arrayTwo, arrayOne, midTwo, endTwo, startOne, midOne);
            }

            if (arrayOne[midOne] < arrayTwo[midTwo])
            {
                return FindMedian(arrayOne, arrayTwo, midOne, endOne, startTwo, midTwo);
            }

            return arrayOne[midOne];
        }
    }
}
