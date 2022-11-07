using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-original-array-of-prefix-xor/description/
    /// </summary>
    public class Leetcode_2433_FindTheOriginalArrayOfPrefixXor_V1
    {
        /// <summary>
        /// List of sub problems
        /// 1. Calculate maximum value from values.
        /// 2. Calculate length of bit array to be formed from maximum value and 
        /// create prefix sum array.
        /// 3. Iterate every item in values array to find out possible integer that can be added to 
        /// prefix XOR array.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int[] FindPrefixXORArray(int[] values)
        {
            var prefixXOR  = new int[values.Length];
            var maxValue = values.Max();
            var bitPosition = 0;
            while ((1 << bitPosition) <= maxValue)
            {
                bitPosition++;
            }
            return prefixXOR;
        }
    }
}
