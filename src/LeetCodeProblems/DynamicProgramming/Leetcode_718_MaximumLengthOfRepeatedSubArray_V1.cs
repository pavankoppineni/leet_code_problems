using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-length-of-repeated-subarray/
    /// </summary>
    public class Leetcode_718_MaximumLengthOfRepeatedSubArray_V1
    {
        public int FindMaximumLengthOfSubArray(int[] arrayOne, int[] arrayTwo)
        {
            var memoryTable = new int[arrayOne.Length, arrayTwo.Length];
            var maxSubArray = 0;
            for (var row = 0; row < arrayOne.Length; row++)
            {
                for (var column = 0; column < arrayTwo.Length; column++)
                {   
                    if (arrayOne[row] == arrayTwo[column])
                    {
                        if (row == 0 || column == 0)
                        {
                            memoryTable[row, column] = 1;
                        }
                        else
                        {
                            memoryTable[row, column] = memoryTable[row - 1, column - 1] + 1;
                        }
                        if (memoryTable[row, column] > maxSubArray)
                        {
                            maxSubArray = memoryTable[row, column];
                        }
                    }
                }
            }
            return maxSubArray;
        }
    }
}
