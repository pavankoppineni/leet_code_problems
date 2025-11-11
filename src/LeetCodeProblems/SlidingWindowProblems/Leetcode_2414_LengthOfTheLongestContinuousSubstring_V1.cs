using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-the-longest-alphabetical-continuous-substring/description/
    /// </summary>
    public class Leetcode_2414_LengthOfTheLongestContinuousSubstring_V1
    {
        public int Calculate(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }

            if (str.Length == 1) 
            {
                return 1;
            }

            var maxLength = 0;
            var currentLength = 1;
            for (var index = 1; index < str.Length; index++)
            {
                var prev = str[index - 1];
                var current = str[index];
                if (current - prev == 1)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                maxLength = Math.Max(maxLength, currentLength);
            }

            return maxLength;
        }
    }
}
