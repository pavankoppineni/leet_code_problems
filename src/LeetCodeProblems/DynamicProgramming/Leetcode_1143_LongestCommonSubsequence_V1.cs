using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-subsequence/
    /// </summary>
    public class Leetcode_1143_LongestCommonSubsequence_V1
    {
        public int Calculate(int[] arrayOne, int[] arrayTwo)
        {
            return Calculate(arrayOne, arrayTwo, 0, 0);
        }

        private int Calculate(int[] arrayOne, int[] arrayTwo, int indexOne, int indexTwo)
        {
            if (indexOne >= arrayOne.Length || indexTwo >= arrayTwo.Length)
            {
                return 0;
            }

            var valueOne = arrayOne[indexOne];
            var valueTwo = arrayTwo[indexTwo];

            //Case 1 : When valueOne is equal to valueTwo
            if (valueOne == valueTwo)
            {
                return 1 + Calculate(arrayOne, arrayTwo, indexOne + 1, indexTwo + 1);
            }

            //Case 2 : When valueOne is not equal to valueTwo
            var left = Calculate(arrayOne, arrayTwo, indexOne, indexTwo + 1);
            var right = Calculate(arrayOne, arrayTwo, indexOne + 1, indexTwo);
            return Math.Max(left, right);
        }
    }
}
