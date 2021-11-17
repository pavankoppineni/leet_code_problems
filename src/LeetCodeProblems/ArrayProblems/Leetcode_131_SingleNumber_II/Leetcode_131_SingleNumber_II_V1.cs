using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_131_SingleNumber_II
{
    /// <summary>
    /// https://leetcode.com/problems/single-number-ii/
    /// </summary>
    public class Leetcode_131_SingleNumber_II_V1
    {
        public int FindSingleNumber(int[] values)
        {
            var positveSum = 0;
            var negativeSum = 0;
            foreach (var value in values)
            {
                if (value < 0)
                {
                    negativeSum += value;
                }
                else
                {
                    positveSum += value;
                }
            }

            if (negativeSum == 0)
            {
                if (negativeSum % 3 > 0)
                {
                    return negativeSum % 3;
                }
            }

            return positveSum % 3;
        }
    }
}
