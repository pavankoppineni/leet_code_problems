using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_70_ClimbingStairs
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    public class Leetcode_70_ClimbingStairs_V1
    {
        private int _totalStairs;
        private IDictionary<int, int> _table;
        public int ClimbStairs(int n)
        {
            _table = new Dictionary<int, int>();
            _totalStairs = n;
            var left = CountWaysToClimbs(1);
            var right = CountWaysToClimbs(2);
            return left + right;
        }

        private int CountWaysToClimbs(int currentStair)
        {
            if (currentStair == _totalStairs)
            {
                return 1;
            }
            if (currentStair > _totalStairs)
            {
                return 0;
            }
            if (_table.ContainsKey(currentStair))
            {
                return _table[currentStair];
            }

            var left = CountWaysToClimbs(currentStair + 1);
            var right = CountWaysToClimbs(currentStair + 2);
            _table[currentStair] = left + right;
            return _table[currentStair];
        }
    }
}
