using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-xor-for-each-query/
    /// </summary>
    public class Leetcode_1829_MaximumXORForEachQuery_V1
    {
        public int[] CalculateMaximumForEachQuery(int[] values, int maximumBit)
        {
            int maxValue = (int)Math.Pow(2, maximumBit) - 1;
            var maximumValues = new int[values.Length];
            var previousXOR = 0;
            var length = values.Length;
            for (var i = 0; i < values.Length; i++)
            {
                previousXOR ^= values[i];
                var currentMax = maxValue ^ previousXOR;
                maximumValues[length - i - 1] = currentMax;
            }
            return maximumValues;
        }
    }
}
