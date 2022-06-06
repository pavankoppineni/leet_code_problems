using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2155_AllDivisionsWithTheHighestScoreOfBinaryArray
{
    /// <summary>
    /// https://leetcode.com/problems/all-divisions-with-the-highest-score-of-a-binary-array/
    /// </summary>
    public class Leetcode_2155_AllDivisionsWithTheHighestScoreOfBinaryArray_V1
    {
        public IList<int> CalculateMaxScore(int[] values)
        {
            var maxScore = 0;
            var lookup = new Dictionary<int, IList<int>>();
            var sum = values.Sum();
            lookup.Add(sum, new List<int>() { 0 });
            maxScore = sum;
            var prefixSum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                prefixSum += values[i];
                var rightSum = sum - prefixSum;
                var leftSum = i + 1 - prefixSum;
                var score = rightSum + leftSum;
                if (!lookup.ContainsKey(score))
                {
                    lookup.Add(score, new List<int>());
                }
                lookup[score].Add(i + 1);
                if (score > maxScore)
                {
                    maxScore = score;
                }
            }
            return lookup[maxScore];
        }
    }
}
