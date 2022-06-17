using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1304_FindNUniqueIntegersSumUpToZero
{
    /// <summary>
    /// https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
    /// </summary>
    public class Leetcode_1304_FindNUniqueIntegersSumUpToZero_V1
    {
        public int[] SumZero(int n)
        {
            var values = new List<int>();
            var half = n / 2;
            var offset = 1;
            while (half > 0)
            {
                values.Add(offset);
                values.Add(offset * -1);
                offset++;
                half--;
            }
            if(n % 2 > 0)
            {
                values.Add(0);
            }
            return values.ToArray();
        }
    }
}
