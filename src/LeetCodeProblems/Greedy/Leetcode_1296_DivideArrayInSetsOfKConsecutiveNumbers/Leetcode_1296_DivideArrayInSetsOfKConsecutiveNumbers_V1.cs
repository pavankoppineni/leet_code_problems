using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Greedy.Leetcode_1296_DivideArrayInSetsOfKConsecutiveNumbers
{
    /// <summary>
    /// https://leetcode.com/problems/divide-array-in-sets-of-k-consecutive-numbers/
    /// </summary>
    public class Leetcode_1296_DivideArrayInSetsOfKConsecutiveNumbers_V1
    {
        public bool IsPossibleDivide(int[] nums, int k)
        {
            var lookup = new SortedDictionary<int, int>();
            foreach (var num in nums)
            {
                if (lookup.ContainsKey(num))
                {
                    lookup[num]++;
                }
                else
                {
                    lookup.Add(num, 1);
                }
            }
            bool result;
            do
            {
                result = RemoveSubset(lookup, k);
            } while (result && lookup.Count > 0);
            return result;
        }

        private bool RemoveSubset(IDictionary<int, int> lookup, int k)
        {
            var min = lookup.Keys.First();
            while (k > 0)
            {
                if (lookup.ContainsKey(min))
                {
                    lookup[min]--;
                    if (lookup[min] == 0)
                    {
                        lookup.Remove(min);
                    }
                }
                else
                {
                    break;
                }
                min += 1;
                k--;
            }
            return k == 0;
        }
    }
}
