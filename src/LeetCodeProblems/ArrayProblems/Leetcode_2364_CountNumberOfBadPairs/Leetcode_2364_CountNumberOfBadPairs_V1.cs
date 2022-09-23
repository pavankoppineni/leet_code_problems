using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2364_CountNumberOfBadPairs
{
    /// <summary>
    /// https://leetcode.com/problems/count-number-of-bad-pairs/
    /// </summary>
    public class Leetcode_2364_CountNumberOfBadPairs_V1
    {
        public long CalculateNumberOfBadPairs(int[] values)
        {
            long totalPairs = values.Length * (values.Length - 1) / 2;
            var lookup = new Dictionary<int, int>();
            for (var index = 0; index < values.Length; index++)
            {
                values[index] = index - values[index];
                if (lookup.ContainsKey(values[index]))
                {
                    lookup[values[index]]++;
                }
                else
                {
                    lookup.Add(values[index], 1);
                }
            }
            long numberOfGoodPairs = 0;
            foreach (var pair in lookup)
            {
                if (pair.Value > 1)
                {
                    numberOfGoodPairs += pair.Value * (pair.Value - 1) / 2; ;
                }
            }
            return totalPairs - numberOfGoodPairs;
        }
    }
}
