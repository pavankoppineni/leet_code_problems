using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals/description/?envType=problem-list-v2&envId=greedy
    /// </summary>
    public class Leetcode_1481_LeastNumberOfUniqueIntegersAfterKRemovals_V1
    {
        public int Calculate(int[] arr, int k)
        {
            var lastIndex = -1;
            var lookup = CreateLookup(arr);
            var countValues = CreateCountValues(lookup);
            for (var index = 0; index < countValues.Length; index++)
            {
                var value = countValues[index];
                if (value > k)
                {
                    lastIndex = index;
                    break;
                }

                k -= value;
            }

            if (lastIndex == -1)
            {
                return 0;
            }

            return countValues.Length - lastIndex + 1;
        }

        private static int[] CreateCountValues(IDictionary<int, int> lookup)
        {
            var countValues = new int[lookup.Count];
            var index = 0;
            foreach (var lookupItem in lookup)
            {
                countValues[index] = lookupItem.Value;
                index++;
            }

            Array.Sort(countValues);
            return countValues;
        }

        private static IDictionary<int, int> CreateLookup(int[] arr)
        {
            var lookup = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (lookup.ContainsKey(item))
                {
                    lookup[item]++;
                }
                else
                {
                    lookup.Add(item, 1);
                }
            }
            return lookup;
        }
    }

    public class ValueItem1481
    {
        public int Value { get; set; }
        public int Count {  get; set; }
    }
}
