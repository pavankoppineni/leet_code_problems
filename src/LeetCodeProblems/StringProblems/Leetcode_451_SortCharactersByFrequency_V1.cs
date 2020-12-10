using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sort-characters-by-frequency/
    /// </summary>
    public class Leetcode_451_SortCharactersByFrequency_V1
    {
        public string FrequencySort(string text)
        {
            if (text == null)
            {
                return null;
            }

            if (text.Length <= 1)
            {
                return text;
            }

            var charDict = new Dictionary<char, int>();
            foreach (var character in text)
            {
                if (charDict.ContainsKey(character))
                {
                    charDict[character] += 1;
                }
                else
                {
                    charDict.Add(character, 1);
                }
            }

            var keyValues = charDict.ToArray();
            Array.Sort(keyValues, new SortByFrequencyComparer());
            var charList = new char[text.Length];
            var currentIndex = 0;
            foreach (var keyValue in keyValues)
            {
                var currentCount = keyValue.Value;
                while (currentCount > 0)
                {
                    charList[currentIndex] = keyValue.Key;
                    currentIndex += 1;
                    currentCount -= 1;
                }
            }

            return new string(charList);
        }

        public struct SortByFrequencyComparer : IComparer<KeyValuePair<char, int>>
        {
            public int Compare(KeyValuePair<char, int> x, KeyValuePair<char, int> y)
            {
                // Case 1 : count of x is greater than y
                // Action : Return 1
                if (x.Value > y.Value)
                {
                    return -1;
                }

                // Case 2 : Count of x is less than y
                // Action : Return -1
                if (x.Value < y.Value)
                {
                    return 1;
                }

                // Case 3 : Count of x is equal to count of y
                return x.Key.CompareTo(y.Key);
            }
        }
    }
}
