using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-absolute-differences-in-a-sorted-array/
    /// </summary>
    public class Leetcode_1685_SumofAbsoluteDifferencesInSortedArray_V1
    {
        public int[] CalculateSortedDifference(int[] values)
        {
            var result = new int[values.Length];
            for (var index = 1; index < values.Length; index++)
            {
                result[index] = result[index - 1] + Math.Abs(values[index] - values[index - 1]);
            }

            for (var index = values.Length - 2; index >= 0; index--)
            {
                result[index] = result[index + 1] + Math.Abs(values[index] - values[index + 1]);
            }

            return result;
        }
    }
}
