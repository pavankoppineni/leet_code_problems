using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/longest-square-streak-in-an-array/
    /// </summary>
    public class Leetcode_2501_LongestSquareStreakInArray_V1
    {
        public int CalculateLongestSquareStreak(int[] values)
        {
            Array.Sort(values);
            var maxLongestStreak = 0;
            var lookup = new Dictionary<int, bool>();
            foreach (var value in values)
            {
                if (!lookup.ContainsKey(value))
                {
                    lookup.Add(value, false);
                }
            }
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                if (lookup[value])
                {
                    continue;
                }
                lookup[value] = true;
                var currentLongestStreak = 1;
                while (lookup.ContainsKey(value * value))
                {
                    value *= value;
                    lookup[value] = true;
                    currentLongestStreak += 1;
                }
                if (currentLongestStreak > maxLongestStreak)
                {
                    maxLongestStreak = currentLongestStreak;
                }
            }
            if(maxLongestStreak < 2)
            {
                return -1;
            }
            return  maxLongestStreak;
        }
    }
}
