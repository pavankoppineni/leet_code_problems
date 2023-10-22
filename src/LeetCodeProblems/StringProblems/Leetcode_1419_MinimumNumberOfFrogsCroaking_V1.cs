using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-frogs-croaking/
    /// </summary>
    public class Leetcode_1419_MinimumNumberOfFrogsCroaking_V1
    {
        IDictionary<char, char> _croakMap = new Dictionary<char, char>()
        {
            { 'c', ' ' },
            { 'r', 'c' },
            { 'o', 'r' },
            { 'a', 'o' },
            { 'k', 'a' },
        };
        IDictionary<char, int> _croakLookup = new Dictionary<char, int>()
        {
            { 'c', 0 },
            { 'r', 0 },
            { 'o', 0 },
            { 'a', 0 },
            { 'k', 0 },
        };

        public int CalculateMinimumFrogs(string croakOfFrogs)
        {
            var validationResult = ValidateCroakOfFrogs(croakOfFrogs);
            if (!validationResult.Item1)
            {
                return -1;
            }
            return CountMinimumFrongs(validationResult.Item2);
        }

        private int CountMinimumFrongs(int[] countMap)
        {
            var max = 0;
            for (var countIndex = 1; countIndex < countMap.Length; countIndex++)
            {
                countMap[countIndex] += countMap[countIndex - 1];
                max = Math.Max(max, countMap[countIndex]);
            }
            return max;
        }

        private (bool, int[]) ValidateCroakOfFrogs(string croakOfFrogs)
        {
            var countMap = new int[croakOfFrogs.Length + 1];
            var index = 0;
            foreach (var charItem in croakOfFrogs)
            {
                if (charItem == 'c')
                {
                    _croakLookup[charItem] += 1;
                    countMap[index] += 1;
                }
                else
                {
                    var previousChar = _croakMap[charItem];
                    if (_croakLookup[previousChar] == 0)
                    {
                        return (false, Array.Empty<int>());
                    }
                    else
                    {
                        _croakLookup[charItem] += 1;
                        _croakLookup[previousChar] -= 1;
                    }
                    if (charItem == 'k')
                    {
                        countMap[index + 1] = -1;
                    }
                }
                index += 1;
            }
            _croakLookup['k'] = 0;
            if (_croakLookup.Values.Sum() == 0)
            {
                return (true, countMap);
            }
            return (false, Array.Empty<int>());
        }
    }
}
