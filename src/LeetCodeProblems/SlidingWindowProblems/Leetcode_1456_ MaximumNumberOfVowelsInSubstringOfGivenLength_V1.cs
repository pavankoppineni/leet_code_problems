using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/description/?envType=problem-list-v2&envId=sliding-window
    /// </summary>
    public class Leetcode_1456__MaximumNumberOfVowelsInSubstringOfGivenLength_V1
    {
        private readonly HashSet<char> _vowels = new HashSet<char>
        {
            'a', 'e', 'i', 'o', 'u'
        };
        public int Calculate(string str, int k)
        {
            var maxVowelCount = 0;
            var currentVowelCount = 0;
            var lookup = new Dictionary<char, int>();
            for (var index = 0; index < k; index++)
            {
                if (_vowels.Contains(str[index]))
                {
                    var currentChar = str[index];
                    if (!lookup.ContainsKey(currentChar))
                    {
                        lookup.Add(currentChar, 0);
                    }
                    lookup[currentChar] += 1;
                    currentVowelCount++;
                }
            }

            var leftIndex = 0;
            maxVowelCount = Math.Max(maxVowelCount, currentVowelCount);
            for (var currentIndex = k; currentIndex < str.Length; currentIndex++, leftIndex++)
            {
                var currentChar = str[currentIndex];
                var leftChar = str[leftIndex];
                if (_vowels.Contains(leftChar))
                {
                    currentVowelCount--;
                }
                if (_vowels.Contains(currentChar))
                {
                    currentVowelCount++;
                }

                maxVowelCount = Math.Max(maxVowelCount, currentVowelCount);
            }
            return maxVowelCount;
        }
    }
}
