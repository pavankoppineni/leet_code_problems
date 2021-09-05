using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-length-of-repeated-subarray/
    /// </summary>
    public class Leetcode_718_MaximumLengthOfRepeatedSubArray_V2
    {
        public int FindMaximumLengthOfRepeatedSubArray(int[] arrayOne, int[] arrayTwo)
        {
            var maxRepeatedSubArray = 0;
            var matrix = new int[arrayOne.Length, arrayTwo.Length];
            var rows = arrayOne.Length;
            var columns = arrayTwo.Length;
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    //Case 1 : When array one item and array two item are same
                    if (arrayTwo[column] == arrayOne[row])
                    {
                        if (row == 0 || column == 0)
                        {
                            matrix[row, column] = 1;
                        }
                        else
                        {
                            matrix[row, column] = 1 + matrix[row - 1, column - 1];
                        }
                        if(matrix[row, column] > maxRepeatedSubArray)
                        {
                            maxRepeatedSubArray = matrix[row, column];
                        }
                    }
                    //Case 2 : When array one item and array two item are not same
                    else
                    {
                        continue;
                    }
                }
            }
            return maxRepeatedSubArray;
        }
    }
}
