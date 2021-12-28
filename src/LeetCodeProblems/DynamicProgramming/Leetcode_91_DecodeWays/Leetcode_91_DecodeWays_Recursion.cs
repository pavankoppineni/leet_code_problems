using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_91_DecodeWays
{
    /// <summary>
    /// https://leetcode.com/problems/decode-ways/
    /// </summary>
    public class Leetcode_91_DecodeWays_Recursion
    {
        public int DecodeWays(string str)
        {
            return DecodeWays(str, 0, str.Length - 1);
        }

        private int DecodeWays(string str, int start, int end)
        {
            if (start > end)
            {
                return 0;
            }

            if (start == end)
            {
                return 1;
            }

            var diff = end - start;
            if (diff == 1)
            {
                if (str[start] == '1')
                {
                    return 2;
                }
                if (str[start] == '2')
                {
                    if (str[end] <= '6')
                    {
                        return 2;
                    }
                    return 1;
                }
                else
                {
                    return 1;
                }
            }
            return DecodeWays(str, start + 1, end) + DecodeWays(str, start + 2, end);
        }
    }
}
