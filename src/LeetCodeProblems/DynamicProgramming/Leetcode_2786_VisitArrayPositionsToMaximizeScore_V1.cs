using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/visit-array-positions-to-maximize-score/
    /// </summary>
    public class Leetcode_2786_VisitArrayPositionsToMaximizeScore_V1
    {
        private int[] _values;
        private int _parityDifference;
        private IDictionary<int, long> _scoreLookup;
        public long CalculateMaximumScore(int[] values, int parityDifference)
        {
            _scoreLookup = new Dictionary<int, long>();
            _values = values;
            _parityDifference = parityDifference;
            return CalculateMaximumScore(0);
        }

        private long CalculateMaximumScore(int index)
        {
            if (index >= _values.Length)
            {
                return 0;
            }

            if (_scoreLookup.ContainsKey(index))
            {
                return _scoreLookup[index];
            }

            long max = _values[index];
            var parity = _values[index] & 1;
            for (var currentIndex = index + 1; currentIndex < _values.Length; currentIndex++)
            {
                var currentMax = CalculateMaximumScore(currentIndex);
                var currentParity = _values[currentIndex] & 1;
                if (parity != currentParity)
                {
                    currentMax -= _parityDifference;
                }
                currentMax += _values[index];
                max = Math.Max(max, currentMax);
            }

            _scoreLookup.Add(index, max);
            return max;
        }
    }
}
