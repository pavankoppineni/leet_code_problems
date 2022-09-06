using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_2400_NumberOfWaysToReachAPositionAfterExactlyKSteps
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-ways-to-reach-a-position-after-exactly-k-steps/
    /// </summary>
    public class Leetcode_2400_NumberOfWaysToReachAPositionAfterExactlyKSteps_V1
    {
        private int _endPosition;
        private IDictionary<string, double> _lookup;
        private double _denominator = Math.Pow(10, 9) + 7;
        public int CalculateNumberOfWays(int startPosition, int endPostition, int steps)
        {
            _lookup = new Dictionary<string, double>();
            _endPosition = endPostition;
            var numberOfWays = CalculateNumberOfWays(startPosition, steps);
            return (int)(numberOfWays % (int)_denominator);
        }

        private double CalculateNumberOfWays(int currentPosition, int steps)
        {
            var key = $"{currentPosition}_{steps}";
            if (_lookup.ContainsKey(key))
            {
                return _lookup[key];
            }
            if (steps <= 0)
            {
                return currentPosition == _endPosition ? 1 : 0;
            }
            var difference = Math.Abs(currentPosition - _endPosition);
            if (difference > steps)
            {
                return 0;
            }
            var right = CalculateNumberOfWays(currentPosition + 1, steps - 1) % _denominator;
            var left = CalculateNumberOfWays(currentPosition - 1, steps - 1) % _denominator;
            _lookup.Add(key, right + left);
            return _lookup[key];
        }
    }
}
