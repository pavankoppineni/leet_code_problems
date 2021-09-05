using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/longest-increasing-subsequence/
    /// </summary>
    public class Leetcode_300_LongestIncreasingSubsequence_V1
    {
        public int CalculateLongestIncreasingSequence(int[] values)
        {
            var sequenceLengthArray = new int[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                sequenceLengthArray[index] = CalculateLongestIncreasingSequence(index, values, sequenceLengthArray);
            }

            var max = sequenceLengthArray[0];
            foreach (var item in sequenceLengthArray)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        private int CalculateLongestIncreasingSequence(int index, int[] values, int[] sequenceArray)
        {
            var maxSequenceLen = 1;
            for (var currentIndex = 0; currentIndex < index; currentIndex++)
            {
                if (sequenceArray[currentIndex] > maxSequenceLen)
                {
                    if (sequenceArray[currentIndex] > maxSequenceLen)
                    {
                        maxSequenceLen = sequenceArray[currentIndex];
                    }
                }
            }

            return maxSequenceLen + 1;
        }
    }
}
