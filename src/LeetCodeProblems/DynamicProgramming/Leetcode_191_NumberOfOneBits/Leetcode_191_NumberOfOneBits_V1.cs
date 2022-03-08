using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_191_NumberOfOneBits
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-1-bits/
    /// </summary>
    public class Leetcode_191_NumberOfOneBits_V1
    {
        public int CalculateHammingWeight(uint number)
        {
            if (number == 0)
            {
                return 0;
            }

            if (number == 1 || number == 2)
            {
                return 1;
            }
            //Case 1 : Number is odd
            if ((number & 1) == 1)
            {
                return CalculateHammingWeight(number >> 1) + 1;
            }
            //Case 2 : Number is even
            return CalculateHammingWeight(number >> 1);
        }
    }
}
