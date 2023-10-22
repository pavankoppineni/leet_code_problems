using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BitManipulation
{
    /// <summary>
    /// https://leetcode.com/problems/neighboring-bitwise-xor/
    /// </summary>
    public class Leetcode_2683_NeighboringBitwiseXOR_V1
    {
        public bool DoesValidArrayExist(int[] derived)
        {
            var originalArray = new int[derived.Length];
            if (derived[0] == 0)
            {
                originalArray[0] = 0;
                originalArray[1] = 0;
            }
            else
            {
                originalArray[0] = 1;
                originalArray[1] = 0;
            }
            for (var index = 1; index < derived.Length - 1; index++)
            {
                if (derived[index] == 0)
                {
                    originalArray[index + 1] = originalArray[index];
                }
                else
                {
                    originalArray[index + 1] = originalArray[index] == 0 ? 1 : 0;
                }
            }

            if (derived[derived.Length - 1] == 1)
            {
                return originalArray[0] != originalArray[derived.Length - 1];
            }
            return originalArray[0] == originalArray[derived.Length - 1];
        }
    }
}
