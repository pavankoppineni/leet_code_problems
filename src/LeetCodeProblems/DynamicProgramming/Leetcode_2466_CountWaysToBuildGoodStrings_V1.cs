using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/count-ways-to-build-good-strings/
    /// </summary>
    public class Leetcode_2466_CountWaysToBuildGoodStrings_V1
    {
        private int _zeroCount;
        private int _oneCount;
        private IDictionary<int, int> _lookup;
        public int CountGoodStrings(int low, int high, int zero, int one)
        {
            _lookup = new Dictionary<int, int>();
            _oneCount = one;
            _zeroCount = zero;
            var goodStringsCount = 0;
            while (high >= low)
            {
                goodStringsCount += CountGoodStrings(high);
                high--;
            }
            return goodStringsCount;
        }

        private int CountGoodStrings(int stringLength)
        {
            if (_lookup.ContainsKey(stringLength))
            {
                return _lookup[stringLength];
            }
            if (stringLength == 0)
            {
                return 1;
            }

            if (stringLength < 0)
            {
                return 0;
            }

            var leftCount = CountGoodStrings(stringLength - _zeroCount);
            var rightCount = CountGoodStrings(stringLength - _oneCount);
            _lookup.Add(stringLength, leftCount + rightCount);
            return leftCount + rightCount;
        }
    }
}
