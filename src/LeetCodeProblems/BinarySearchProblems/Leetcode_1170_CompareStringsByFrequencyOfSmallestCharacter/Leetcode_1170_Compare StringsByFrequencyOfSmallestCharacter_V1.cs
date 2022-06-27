using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_1170_Compare_StringsByFrequencyOfSmallestCharacter
{
    /// <summary>
    /// https://leetcode.com/problems/compare-strings-by-frequency-of-the-smallest-character/
    /// </summary>
    public class Leetcode_1170_Compare_StringsByFrequencyOfSmallestCharacter_V1
    {
        private int[] _wordsFrequency;
        public int[] CalculateFrequency(string[] queries, string[] words)
        {
            var queryResult = new int[queries.Length];
            _wordsFrequency = CalculateWordsFrequency(words);
            for (var index = 0; index < queries.Length; index++)
            {
                var minWordFrequency = CalculateWordFrequency(queries[index]);
                var result = Search(0, _wordsFrequency.Length - 1, minWordFrequency + 1);
                if(result == -1)
                {
                    queryResult[index] = 0;
                }
                else
                {
                    queryResult[index] = words.Length - result;
                }
            }
            return queryResult;
        }

        private int Search(int start, int end, int queryFrequency)
        {
            if (start > end)
            {
                return -1;
            }
            if (start == end)
            {
                if (_wordsFrequency[start] >= queryFrequency)
                {
                    return start;
                }
                else
                {
                    return -1;
                }
            }
            var mid = start + ((end - start) / 2);
            //Case 1 : When query frequency is greater than or equal to mid
            //Action : Search left half
            if (queryFrequency > _wordsFrequency[mid])
            {
                return Search(mid + 1, end, queryFrequency);
            }
            //Case 2 : When query frequency is less than mid
            //Action : Search left half
            else
            {
                return Search(start, mid, queryFrequency);
            }
        }

        private int[] CalculateWordsFrequency(string[] words)
        {
            var wordsFrequency = new int[words.Length];
            for (var currentWordIndex = 0; currentWordIndex < words.Length; currentWordIndex++)
            {
                wordsFrequency[currentWordIndex] = CalculateWordFrequency(words[currentWordIndex]);
            }
            Array.Sort(wordsFrequency);
            return wordsFrequency;
        }

        private int CalculateWordFrequency(string word)
        {
            var count = 1;
            var min = word[0];
            for (var index = 1; index < word.Length; index++)
            {
                var currentChar = word[index];
                if (currentChar == min)
                {
                    count++;
                    continue;
                }

                if (currentChar > min)
                {
                    continue;
                }

                if (currentChar < min)
                {
                    min = currentChar;
                    count = 1;
                }
            }
            return count;
        }
    }
}
