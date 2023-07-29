using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-beauty-of-an-array-after-applying-operation/
    /// </summary>
    public class Leetcode_2779_MaximumBeautyOfAnArrayAfterApplyingOperation_V1
    {
        public int CalculateMaximumBeauty(int[] values, int k)
        {
            var min = values.Min() - k;
            var max = values.Max() + k;
            var offset = min < 0 ? Math.Abs(min) : 0;
            var arrayLookup = new int[max + offset + k + 2];
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                var currentMin = value + offset - k;
                var currentMax = value + offset + k;
                arrayLookup[currentMin] += 1;
                arrayLookup[currentMax + 1] -= 1;
            }
            var maximumBeauty = 0;
            for (var index = 1; index < arrayLookup.Length; index++)
            {
                arrayLookup[index] += arrayLookup[index - 1];
                maximumBeauty = Math.Max(maximumBeauty, arrayLookup[index]);
            }
            return maximumBeauty;
        }
    }
}
