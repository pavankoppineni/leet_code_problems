using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/squares-of-a-sorted-array/
    /// </summary>
    public class Leetcode_977_SquaresOfSortedArray_V1
    {
        public int[] SortedSquares(int[] values)
        {
            var resultArray = new int[values.Length];
            var currentIndex = values.Length - 1;
            var leftIndex = 0;
            var rightIndex = values.Length - 1;
            while (leftIndex <= rightIndex)
            {
                var leftAbs = Math.Abs(values[leftIndex]);
                var rightAbs = Math.Abs(values[rightIndex]);

                //Case 1 : Left value less than right value
                if (leftAbs < rightAbs)
                {
                    resultArray[currentIndex] = rightAbs * rightAbs;
                    rightIndex -= 1;
                    currentIndex -= 1;
                }
                else
                {
                    resultArray[currentIndex] = leftAbs * leftAbs;
                    leftIndex += 1;
                    currentIndex -= 1;
                }
            }

            return resultArray;
        }
    }
}
