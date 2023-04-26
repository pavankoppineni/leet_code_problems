using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-additions-to-make-valid-string/
    /// </summary>
    public class Leetcode_2645_MinimumAdditionsToMakeValidString_V1
    {
        public int CalculateMinimum(string word)
        {
            var previousMap = new Dictionary<char, char>();
            previousMap.Add('a', 'c');
            previousMap.Add('b', 'a');
            previousMap.Add('c', 'b');
            var count = 0;
            var prevIndex = 0;
            for (var index = 1; index < word.Length; index++)
            {
                if (word[prevIndex] == word[index])
                {
                    count += 2;
                    continue;
                }

                var previousChar = previousMap[word[index]];
                if (word[prevIndex] != previousChar)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
