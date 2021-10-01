using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-width-ramp/
    /// </summary>
    public class Leetcode_962_MaximumWidthRamp_V2
    {
        public int FindMaxWidthRamp(int[] values)
        {
            var pairs = new List<Pair>();
            for (var index = 0; index < values.Length; index++)
            {
                var pair = new Pair(index, values[index]);
                pairs.Add(pair);
            }
            pairs.Sort(Pair.Comparer);
            var maxWidth = 0;
            var minIndex = pairs[0].Index;
            foreach (var pair in pairs)
            {
                //Case 1 : When current index - minIndex is greater than maxWidth
                //Action : Assign new maxWidth
                if (pair.Index - minIndex > maxWidth)
                {
                    maxWidth = pair.Index - minIndex;
                }

                //Case 2 : When current index is min index
                //Action : Assign current index as min index
                if (pair.Index < minIndex)
                {
                    minIndex = pair.Index;
                }
            }
            return maxWidth;
        }

        public class Pair : IComparer<Pair>
        {
            public int Index { get; private set; }
            public int Value { get; private set; }

            public static IComparer<Pair> Comparer => new Pair();

            private Pair() { }

            public Pair(int index, int value)
            {
                Index = index;
                Value = value;
            }

            public int Compare(Pair x, Pair y)
            {
                if (x.Value == y.Value)
                {
                    return x.Index.CompareTo(y.Index);
                }
                return x.Value.CompareTo(y.Value);
            }
        }
    }
}
