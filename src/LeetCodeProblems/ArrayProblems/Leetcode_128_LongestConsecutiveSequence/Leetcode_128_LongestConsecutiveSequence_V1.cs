using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_128_LongestConsecutiveSequence
{
    /// <summary>
    /// https://leetcode.com/problems/longest-consecutive-sequence/
    /// </summary>
    public class Leetcode_128_LongestConsecutiveSequence_V1
    {
        public int CalculateLongestSequence(int[] values)
        {
            if (values.Length <= 1)
            {
                return values.Length;
            }

            var lookup = new Dictionary<int, bool>();
            foreach (var value in values)
            {
                if (!lookup.ContainsKey(value))
                {
                    lookup.Add(value, false);
                }
            }

            var maxSequence = 1;
            foreach (var value in values)
            {
                var currenctSequence = 1;
                if (lookup[value])
                {
                    continue;
                }
                lookup[value] = true;

                //Case One : Decrement
                var leftValue = value - 1;
                while (lookup.ContainsKey(leftValue))
                {
                    lookup[leftValue] = true;
                    currenctSequence++;
                    leftValue -= 1;
                }

                //Case Two : Increment
                var rightValue = value + 1;
                while (lookup.ContainsKey(rightValue))
                {
                    lookup[rightValue] = true;
                    currenctSequence++;
                    rightValue += 1;
                }

                if (currenctSequence > maxSequence)
                {
                    maxSequence = currenctSequence;
                }
            }
            return maxSequence;
        }
    }
}
