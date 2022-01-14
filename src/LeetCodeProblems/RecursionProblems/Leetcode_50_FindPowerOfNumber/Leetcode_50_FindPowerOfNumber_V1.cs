using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.RecursionProblems
{
    /// <summary>
    /// https://leetcode.com/problems/powx-n/
    /// </summary>
    public class Leetcode_50_FindPowerOfNumber_V1
    {
        public int FindPower(int baseNumber, int exponent)
        {
            if(baseNumber == 0)
            {
                return 0;
            }

            if(exponent == 0)
            {
                return 1;
            }

            if(exponent == 1)
            {
                return baseNumber;
            }

            var isOdd = exponent & 1;
            if (isOdd == 1)
            {
                var result = FindPower(baseNumber, exponent / 2);
                return result * result * baseNumber;
            }
            else
            {
                var result = FindPower(baseNumber, exponent / 2);
                return result * result;
            }
        }
    }
}
