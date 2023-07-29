using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/delete-and-earn/
    /// </summary>
    public class Leetcode_740_DeleteAndEarn_V1
    {
        public int CalculateMaximumPoints(int[] values)
        {
            var lookup = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (!lookup.ContainsKey(value))
                {
                    lookup.Add(value, 0);
                }
                lookup[value] += 1;
            }

            var scoreLookup = new Dictionary<int, Score>();
            var keys = lookup.Keys.ToArray();
            Array.Sort(keys);
            var score = Score.Create(keys[0] * lookup[keys[0]], 0);
            scoreLookup.Add(keys[0], score);
            for (var index = 1; index < keys.Length; index++)
            {
                var currentKey = keys[index];
                var previousKey = keys[index - 1];
                var previousScore = scoreLookup[previousKey];
                if (currentKey - keys[index - 1] == 1)
                {
                    var currentScore = Score.Create(previousScore.Exclusive + (lookup[currentKey] * currentKey), previousScore.Max);
                    scoreLookup.Add(currentKey, currentScore);
                }
                else
                {
                    var currentScore = Score.Create(previousScore.Max + (lookup[currentKey] * currentKey), previousScore.Max);
                    scoreLookup.Add(currentKey, currentScore);
                }
            }
            return scoreLookup[keys.Max()].Max;
        }
    }

    public class Score
    {
        public int Inclusive { get; set; }
        public int Exclusive { get; set; }
        public int Max => Math.Max(Inclusive, Exclusive);

        public static Score Create(int inclusive, int exclusive)
        {
            return new Score
            {
                Inclusive = inclusive,
                Exclusive = exclusive
            };
        }
    }
}
