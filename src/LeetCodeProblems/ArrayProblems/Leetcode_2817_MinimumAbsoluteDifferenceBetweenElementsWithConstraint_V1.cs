using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-absolute-difference-between-elements-with-constraint/
    /// </summary>
    public class Leetcode_2817_MinimumAbsoluteDifferenceBetweenElementsWithConstraint_V1
    {
        public int CalculateMinimumDifference(int[] values, int difference)
        {
            throw new NotImplementedException();
        }
    }

    public class ArrayItem_2817 : IComparer<ArrayItem_2817>
    {
        public static IComparer<ArrayItem_2817> Comparer = new ArrayItem_2817();
        public int Index { get; set; }
        public int Value { get; set; }

        public static ArrayItem_2817[] CreateFrom(int[] values)
        {
            var items = new ArrayItem_2817[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                items[index] = new ArrayItem_2817 { Index = index, Value = values[index] };
            }
            return items;
        }

        public int Compare(ArrayItem_2817 x, ArrayItem_2817 y)
        {
            return x.Value.CompareTo(y.Value);
        }
    }
}
