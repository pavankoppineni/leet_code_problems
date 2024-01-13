using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/vowels-of-all-substrings/
    /// </summary>
    public class Leetcode_2063_VowelsOfAllSubstrings_V1
    {
        public long CountVowelSubstrings(string str)
        {
            var vowelLookup = new HashSet<char>()
            {
                'a', 'e', 'i', 'o', 'u'
            };
            var previousCount = 0;
            long count = 0;
            for (var index = 0; index < str.Length; index++)
            {
                //When : character is vowel
                //Then :
                if (vowelLookup.Contains(str[index]))
                {
                    previousCount += index + 1;
                    count += previousCount;
                    continue;
                }

                //When : character is consonant
                //Then : 
                count += previousCount;
            }
            return count;
        }
    }
}
