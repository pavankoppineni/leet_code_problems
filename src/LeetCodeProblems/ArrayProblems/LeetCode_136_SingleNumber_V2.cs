using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/single-number/
    /// </summary>
    public class LeetCode_136_SingleNumber_V2
    {
        public int FindSingleNumber(int[] values)
        {
            var singleNumber = values[0];
            for(var index = 1; index < values.Length; index++)
            {
                singleNumber ^= values[index];
            }

            return singleNumber;
        }
    }
}
