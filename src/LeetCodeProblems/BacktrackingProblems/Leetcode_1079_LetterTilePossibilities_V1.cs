using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/letter-tile-possibilities/
    /// </summary>
    public class Leetcode_1079_LetterTilePossibilities_V1
    {
        private int[] _letterCount;
        public int CalculatePossibilities(string tiles)
        {
            var lookup = new Dictionary<char, int>();
            foreach (var tile in tiles)
            {
                if (!lookup.ContainsKey(tile))
                {
                    lookup.Add(tile, 0);
                }
                lookup[tile] += 1;
            }
            _letterCount = new int[lookup.Count];
            var index = 0;
            foreach (var item in lookup)
            {
                _letterCount[index] = item.Value;
                index++;
            }

            var permutationsCount = 0;
            for (var len = 1; len <= tiles.Length; len++)
            {
                permutationsCount += GeneratePermutation(0, len);
            }
            return permutationsCount;
        }

        private int GeneratePermutation(int level, int length)
        {
            if (level == length)
            {
                return 1;
            }

            var permutationsCount = 0;
            for (var index = 0; index < _letterCount.Length; index++)
            {
                var count = _letterCount[index];
                if (count == 0)
                {
                    continue;
                }
                _letterCount[index] -= 1;
                permutationsCount += GeneratePermutation(level + 1, length);
                _letterCount[index] += 1;
            }
            return permutationsCount;
        }
    }
}
