using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/range-product-queries-of-powers/
    /// </summary>
    public class Leetcode_2438_RangeProductQueriesOfPowers_V1
    {
        public int[] CalculateProductQueries(int n, int[][] queries)
        {
            var powers = BuildsPowersArrays(n);

            var result = new int[queries.Length];
            for (var index = 0; index < queries.Length; index++)
            {
                var start = queries[index][0];
                var end = queries[index][1];
                var numerator = powers[end];
                var denominator = start == 0 ? 1 : powers[start - 1];
                result[index] = (int)(numerator / denominator);
            }
            return result;
        }

        private IList<long> BuildsPowersArrays(int n)
        {
            var powers = new List<long>();
            var seed = 1;
            var prev = 1;
            while (true)
            {
                var power = 1 << seed;
                if ((n & power) > 0)
                {
                    powers.Add(power * prev);
                    prev *= power;
                }
                if (power > n)
                {
                    break;
                }
                seed++;
            }
            return powers;
        }
    }
}
