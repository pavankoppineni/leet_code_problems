using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/ways-to-split-array-into-good-subarrays/
    /// </summary>
    public class Leetcode_2750_WaysToSplitArrayIntoGoodSubArrays_V1
    {
        public int CalculateNumberOfGoodSubArrays(int[] values)
        {
            var prevOneIndex = -1;
            long numberOfGoodSubArrays = 0;
            var index = 0;
            while (index < values.Length)
            {
                if (values[index] == 1)
                {
                    prevOneIndex = index;
                    break;
                }
                index += 1;
            }

            if(prevOneIndex == -1)
            {
                return 0;
            }

            numberOfGoodSubArrays = 1;
            index += 1;
            for (; index < values.Length; index++)
            {
                if (values[index] == 1)
                {
                    numberOfGoodSubArrays *= (index - prevOneIndex);
                    prevOneIndex = index;
                }
            }

            var toInt = numberOfGoodSubArrays / 1000000007;
            return (int)toInt;
        }
    }
}
