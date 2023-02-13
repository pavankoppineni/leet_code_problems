using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-distinct-roll-sequences/
    /// </summary>
    public class Leetcode_2318_NumberOfDistinctRollSequences_V1
    {
        private int[] _levels;
        private int _upperLevel;
        private IDictionary<int, int[]> _lookup;
        public int CalculateDistinctSequences(int n)
        {
            _levels = new int[n];
            _upperLevel = n;
            _lookup = new Dictionary<int, int[]>()
            {
                { 1, new int[] { 2, 3, 4, 5, 6 }},
                { 2, new int[] { 1, 3, 5 }},
                { 3, new int[] { 1, 2, 4, 5 }},
                { 4, new int[] { 1, 3, 5 }},
                { 5, new int[] { 1, 2, 3, 4, 6 }},
                { 6, new int[] { 1, 5 }},
            };
            var numberOfSequences = 0;
            for (var i = 1; i <= 6; i++)
            {
                _levels[0] = i;
                numberOfSequences += CalculateSequence(0, i);
            }
            return numberOfSequences;
        }

        private int CalculateSequence(int level, int value)
        {
            if (level == _upperLevel - 1)
            {
                _levels[level] = value;
                return 1;
            }
            var numberOfSequences = 0;
            foreach (var item in _lookup[value])
            {
                var newLevel = level + 1;
                if (newLevel - 2 >= 0)
                {
                    if (_levels[newLevel - 2] == item)
                    {
                        continue;
                    }
                }
                _levels[newLevel] = item;
                numberOfSequences += CalculateSequence(newLevel, item);
            }
            return numberOfSequences;
        }
    }
}
