using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/make-costs-of-paths-equal-in-a-binary-tree/
    /// </summary>
    public class Leetcode_2673_MakeCostsOfPathsEqualInBinaryTree_V1
    {
        int[] _costs;
        int _length;
        public int CalculateMinimumIncrements(int n, int[] cost)
        {
            _costs = cost;
            _length = n;
            return CalculateMinimumIncrement(0).minIncrement;
        }

        private (int sum, int minIncrement) CalculateMinimumIncrement(int index)
        {
            if (index >= _length)
            {
                return (0, 0);
            }

            var left = CalculateMinimumIncrement(2 * index + 1);
            var right = CalculateMinimumIncrement(2 * index + 2);
            if (left == right)
            {
                return (left.sum + _costs[index], left.minIncrement + right.minIncrement);
            }
            else
            {
                var diff = Math.Abs(left.sum - right.sum);
                return (_costs[index] + Math.Max(left.sum, right.sum), diff + left.minIncrement + right.minIncrement);
            }
        }
    }
}
