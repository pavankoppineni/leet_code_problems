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
        public int FindLongestIncreasingSubsequence(int[] values)
        {
            var maxSequence = 0;
            var sequenceArray = new int[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                sequenceArray[index] = FindIncreaseingSubsequence(values, index, sequenceArray);
                if (sequenceArray[index] > maxSequence)
                {
                    maxSequence = sequenceArray[index];
                }
            }
            return maxSequence;
        }

        private int FindIncreaseingSubsequence(int[] values, int index, int[] sequenceArray)
        {
            var maxSequence = 0;
            for (var currentIndex = 0; currentIndex < index; currentIndex++)
            {
                if (values[index] > values[currentIndex])
                {
                    if (sequenceArray[currentIndex] > maxSequence)
                    {
                        maxSequence = sequenceArray[currentIndex];
                    }
                }
            }
            return 1 + maxSequence;
        }
    }
}
