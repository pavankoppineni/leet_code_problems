using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-width-ramp/
    /// </summary>
    public class Leetcode_962_MaximumWidthRamp_V1
    {
        public int FindMaximumWidhtRamp(int[] values)
        {
            var pairs = new List<Pair>();
            for (var index = 0; index < values.Length; index++)
            {
                pairs.Add(Pair.Create(values[index], index));
            }
            pairs.Sort(Pair.DefaultComparer);
            var maxWidth = 0;
            var minIndex = pairs[0].Index;
            for (var index = 1; index < values.Length; index++)
            {
                //Case : When Difference is greater than max width
                //Action : Assign new max width
                if (pairs[index].Index - minIndex > maxWidth)
                {
                    maxWidth = pairs[index].Index - minIndex;
                }

                //Case : When current index is smaller than min index
                //Action : Assign new min index
                if (pairs[index].Index < minIndex)
                {
                    minIndex = pairs[index].Index;
                }
            }
            return maxWidth;
        }

        public class Pair : IComparer<Pair>
        {
            public static IComparer<Pair> DefaultComparer = new Pair();
            public int Value { get; set; }
            public int Index { get; set; }

            public static Pair Create(int value, int index)
            {
                return new Pair { Index = index, Value = value };
            }

            public int Compare(Pair x, Pair y)
            {
                if (y.Value == x.Value)
                {
                    return x.Index.CompareTo(y.Index);
                }
                return x.Value.CompareTo(y.Value);
            }
        }
    }
}
