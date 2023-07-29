using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/visit-array-positions-to-maximize-score/
    /// </summary>
    public class Leetcode_2786_VisitArrayPositionsToMaximizeScore_V2
    {
        private int[] _values;
        private int _parityDifference;
        private long _max;
        private IDictionary<int, long> _scoreMemory;
        public long CalculateMaximumScore(int[] values, int parityDifference)
        {
            _values = values;
            _max = _values[0];
            _parityDifference = parityDifference;
            _scoreMemory = new Dictionary<int, long>();
            return CalculateMaximumScore(0);
        }

        private long CalculateMaximumScore(int index)
        {
            throw new NotImplementedException();
        }
    }
}
