using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// </summary>
    public class Leetcode_4_MedianOfTwoSortedArrays_V1
    {
        public double FindMedian(int[] arrayOne, int[] arrayTwo)
        {
            return 1;
        }

        private double FindMedian(int[] arrayOne, int startOne, int endOne, int[] arrayTwo, int startTwo, int endTwo)
        {
            var len = endOne - startOne + 1;
            if (len == 2)
            {
                throw new NotImplementedException();
            }
            var midOne = startOne + ((endOne - startOne) >> 1);
            var midTwo = startTwo + ((endTwo - startTwo) >> 1);

            //Case 1 : midOne is equal to midTwo
            //Action : Return mid
            if (arrayOne[midOne] == arrayTwo[midTwo])
            {
                return arrayOne[midOne];
            }

            //Case 2 : midOne is greater than midTwo
            //Action : 
            if (arrayOne[midOne] > arrayTwo[midTwo])
            {
                return FindMedian(arrayOne, startOne, midOne, arrayTwo, midTwo, endTwo);
            }
            return FindMedian(arrayOne, midOne, endOne, arrayTwo, startTwo, midTwo);
        }
    }
}
