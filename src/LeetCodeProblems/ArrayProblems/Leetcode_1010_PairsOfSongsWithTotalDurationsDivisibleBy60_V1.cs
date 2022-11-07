using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/
    /// </summary>
    public class Leetcode_1010_PairsOfSongsWithTotalDurationsDivisibleBy60_V1
    {
        public int CalculateNumberOfPairs(int[] durations)
        {
            var numberOfPairs = 0;
            var lookup = new Dictionary<int, int>();
            foreach (var duration in durations)
            {
                var reminder = duration % 60;
                var difference = 0;
                if (reminder > 0)
                {
                    difference = 60 - reminder;
                }
                if (lookup.ContainsKey(difference))
                {
                    numberOfPairs += lookup[difference];
                }

                if (!lookup.ContainsKey(reminder))
                {
                    lookup.Add(reminder, 0);
                }
                lookup[reminder]++;
            }
            return numberOfPairs;
        }
    }
}
