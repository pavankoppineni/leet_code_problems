using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-substrings-containing-all-three-characters/
    /// </summary>
    public class Leetcode_1358_NumberOfSubstringsContainingAllThreeCharacters_V1
    {
        public int CalculateNumberOfSubstrings(string str)
        {
            var countOfSubstrings = 0;
            var lookup = new Dictionary<char, int>();
            var start = 0;
            for (var index = 0; index < str.Length; index++)
            {
                if (!lookup.ContainsKey(str[index]))
                {
                    lookup.Add(str[index], 0);
                }
                lookup[str[index]] += 1;
                if (lookup.Count < 3)
                {
                    continue;
                }
                while (lookup.Count == 3)
                {
                    countOfSubstrings += str.Length - index;
                    var charToRemove = str[start];
                    lookup[charToRemove] -= 1;
                    if (lookup[charToRemove] == 0)
                    {
                        lookup.Remove(charToRemove);
                    }
                    start += 1;
                }
            }
            return countOfSubstrings;
        }
    }
}
