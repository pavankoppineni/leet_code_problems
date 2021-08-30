using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/k-diff-pairs-in-an-array/
    /// </summary>
    public class Leetcode_532_KDiffPairsInAnArray_V1
    {
        public int FindPairs(int[] values, int difference)
        {
            var set = new HashSet<int>();
            var pairSet = new HashSet<Pair>(Pair.EqualityComparer);
            foreach (var value in values)
            {
                var addDifference = value + difference;
                var subDifference = value - difference;
                if (set.Contains(addDifference))
                {
                    pairSet.Add(new Pair(value, addDifference));
                }
                if (set.Contains(subDifference))
                {
                    pairSet.Add(new Pair(value, subDifference));
                }
                set.Add(value);
            }
            return pairSet.Count;
        }

        public class Pair : IEqualityComparer<Pair>
        {
            private Pair() { }

            public Pair(int x, int y)
            {
                X = Math.Min(x, y);
                Y = Math.Max(x, y);
            }

            public static IEqualityComparer<Pair> EqualityComparer { get; } = new Pair();

            public int X { get; private set; }
            public int Y { get; private set; }

            public bool Equals(Pair x, Pair y)
            {
                return x.X == y.X && x.Y == y.Y;
            }

            public int GetHashCode(Pair obj)
            {
                return HashCode.Combine(obj.X, obj.Y);
            }
        }
    }
}
