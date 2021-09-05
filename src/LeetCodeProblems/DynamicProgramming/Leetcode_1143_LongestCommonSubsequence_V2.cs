using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-subsequence/
    /// </summary>
    public class Leetcode_1143_LongestCommonSubsequence_V2
    {
        public int FindLongestCommonSubsequence(string strOne, string strTwo)
        {
            var matrix = new int[strOne.Length, strTwo.Length];
            for (var row = 0; row < strOne.Length; row++)
            {
                for (var column = 0; column < strTwo.Length; column++)
                {
                    matrix[row, column] = -1;
                }
            }
            return FindLongestCommonSubsequence(strOne, strTwo, 0, 0, matrix);
        }

        private int FindLongestCommonSubsequence(string strOne, string strTwo, int indexOne, int indexTwo, int[,] matrix)
        {
            if (indexOne >= strOne.Length || indexTwo >= strTwo.Length)
            {
                return 0;
            }

            if (matrix[indexOne, indexTwo] > -1)
            {
                return matrix[indexOne, indexTwo];
            }

            //Case 1 : When indexOne equals to indexTwo
            if (strOne[indexOne] == strTwo[indexTwo])
            {
                matrix[indexOne, indexTwo] = 1 + FindLongestCommonSubsequence(strOne, strTwo, indexOne + 1, indexTwo + 1, matrix);
                return matrix[indexOne, indexTwo];
            }

            var left = FindLongestCommonSubsequence(strOne, strTwo, indexOne, indexTwo + 1, matrix);
            var right = FindLongestCommonSubsequence(strOne, strTwo, indexOne + 1, indexTwo, matrix);
            matrix[indexOne, indexTwo] = Math.Max(left, right);
            return matrix[indexOne, indexTwo];
        }
    }
}
