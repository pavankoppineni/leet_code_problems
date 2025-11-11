using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-suffix-flips/description/?envType=problem-list-v2&envId=greedy
    /// </summary>
    public class Leetcode_1529_MinimumSuffixFlips_V1
    {
        public int MinimumFlips(string target)
        {
            var count = 0;
            var lastChar = '0';
            foreach (var targetChar in target)
            {
                if (targetChar != lastChar)
                {
                    count += 1;
                    lastChar = targetChar;
                }
            }

            return count;
        }
    }
}
