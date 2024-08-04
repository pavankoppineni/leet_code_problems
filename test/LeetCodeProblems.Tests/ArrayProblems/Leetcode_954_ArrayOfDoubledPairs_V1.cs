using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/array-of-doubled-pairs/
    /// </summary>
    public class Leetcode_954_ArrayOfDoubledPairs_V1
    {
        public bool CanReorder(int[] values)
        {
            if (values.Length == 0)
            {
                return true;
            }

            Array.Sort(values, CustomComparer.Comparer);
            var halfLength = values.Length >> 1;
            var count = 0;
            var lookup = CreateLookup(values);
            for (int index = 0; index < values.Length; index++)
            {
                var value = values[index];
                if (lookup[value] <= 0)
                {
                    continue;
                }

                var doubleValue = value * 2;
                lookup[value] -= 1;
                if (!lookup.ContainsKey(doubleValue))
                {
                    return false;
                }

                if (lookup[doubleValue]<= 0)
                {
                    return false;
                }

                count += 1;
                lookup[doubleValue] -= 1;
                if (count >= halfLength)
                {
                    return true;
                }
            }
            return false;
        }

        private static IDictionary<int, int> CreateLookup(int[] values)
        {
            var lookup = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (!lookup.ContainsKey(value))
                {
                    lookup.Add(value, 1);
                    continue;
                }
                lookup[value]++;
            }
            return lookup;
        }
    }

    public class CustomComparer : IComparer<int>
    {
        public static IComparer<int> Comparer = new CustomComparer();

        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x < 0 && y < 0)
            {
                x *= -1;
                y *= -1;
            }

            return x.CompareTo(y);
        }
    }
}
