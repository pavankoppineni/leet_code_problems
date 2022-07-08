using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems.Leetcode_2024_MaximizeTheConfusionOfExam
{
    /// <summary>
    /// https://leetcode.com/problems/maximize-the-confusion-of-an-exam/
    /// </summary>
    public class Leetcode_2024_MaximizeTheConfusionOfExam_V1
    {
        public int CalculateMaximumConfusion(string answerKey, int k)
        {
            var maximumConfusion = 0;
            var lookup = new Dictionary<(int sum, bool key), int>();
            var prefixSum = 0;
            for (var index = 0; index < answerKey.Length; index++)
            {
                var key = answerKey[index];
                if (key == 'T')
                {
                    prefixSum += 1;
                    lookup.Add((prefixSum, true), index);
                }
                else
                {
                    lookup.Add((index + 1 - prefixSum, false), index);
                }
                lookup.TryGetValue((prefixSum - k, true), out int truePrefixSumIndex);
                lookup.TryGetValue(((index + 1 - prefixSum) - k, false), out int falsePrefixSumIndex);
                var trueLength = index - truePrefixSumIndex;
                var falseLength = index - falsePrefixSumIndex;
                maximumConfusion = Math.Max(maximumConfusion, Math.Max(trueLength, falseLength));
            }
            return maximumConfusion;
        }
    }
}
