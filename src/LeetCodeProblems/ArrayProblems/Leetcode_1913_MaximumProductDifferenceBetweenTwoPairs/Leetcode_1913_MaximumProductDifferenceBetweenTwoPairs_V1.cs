using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1913_MaximumProductDifferenceBetweenTwoPairs
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
    /// </summary>
    public class Leetcode_1913_MaximumProductDifferenceBetweenTwoPairs_V1
    {
        public int ClaculateMaximumProduct(int[] values)
        {
            var result = 0;
            var small_first = Math.Min(values[0], values[1]);
            var small_second = Math.Max(values[0], values[1]);
            var large_first = small_second;
            var large_second = small_first;
            for (var index = 2; index < values.Length; index++)
            {
                var value = values[index];
                if (value < small_first)
                {

                }
            }
            return result;
        }
    }
}
