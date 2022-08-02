using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_1231_DivideChocolates
{
    /// <summary>
    /// https://leetcode.ca/all/1231.html
    /// </summary>
    public class Leetcode_1231_DivideChocolates_V1
    {
        private int[] _sweetness;
        private int[] _prefixSum;
        private IDictionary<int, int> _lookup;
        public int CalculateMaximumTotalSweetness(int[] sweetness, int friends)
        {
            _lookup = new Dictionary<int, int>();
            _prefixSum = new int[sweetness.Length];
            _sweetness = sweetness;
            _prefixSum[0] = sweetness[0];
            for (var index = 1; index < sweetness.Length; index++)
            {
                _prefixSum[index] = sweetness[index] + _prefixSum[index - 1];
            }
            return CalculateMaximumTotalSweetness(0, friends);
        }

        private int CalculateMaximumTotalSweetness(int startIndex, int friends)
        {
            //if (_lookup.ContainsKey(startIndex))
            //{
            //    return _lookup[startIndex];
            //}
            if (friends == 0)
            {
                return _prefixSum[_sweetness.Length - 1] - _prefixSum[startIndex - 1];
            }

            var max = 0;
            var prefixSum = 0;
            var length = _sweetness.Length - startIndex;
            for (var index = 0; index <= length - friends; index++)
            {
                prefixSum += _sweetness[startIndex + index];
                var min = CalculateMaximumTotalSweetness(startIndex + index + 1, friends - 1);
                var currentMin = Math.Min(min, prefixSum);
                max = Math.Max(currentMin, max);
            }
            //_lookup.Add(startIndex, max);
            return max;
        }
    }
}
