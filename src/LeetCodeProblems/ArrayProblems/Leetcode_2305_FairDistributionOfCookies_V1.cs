using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/fair-distribution-of-cookies/
    /// </summary>
    public class Leetcode_2305_FairDistributionOfCookies_V1
    {
        private int[] _childrenWithCookies;
        private int[] _cookies;
        private int _childrenCount;
        private int _minimumPossibleDistribution = int.MaxValue;
        public int CalculateFairDistribution(int[] cookies, int childrenCount)
        {
            _childrenWithCookies = new int[childrenCount];
            _cookies = cookies;
            _childrenCount = childrenCount;
            CalculateFairDistribution(0);
            return _minimumPossibleDistribution;
        }

        private void CalculateFairDistribution(int cookieIndex)
        {
            if (cookieIndex >= _cookies.Length)
            {
                _minimumPossibleDistribution = Math.Min(_minimumPossibleDistribution, _childrenWithCookies.Max());
                return;
            }

            for (var index = 0; index < _childrenCount; index++)
            {
                _childrenWithCookies[index] += _cookies[cookieIndex];
                CalculateFairDistribution(cookieIndex + 1);
                _childrenWithCookies[index] -= _cookies[cookieIndex];
            }
        }
    }
}
