using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/fruit-into-baskets/
    /// </summary>
    public class Leetcode_904_FruitIntoBaskets_V1
    {
        public int CalculateMaximumNumberOfFruits(int[] fruits)
        {
            var firstMax = 0;
            var secondMax = 0;
            var lookup = new Dictionary<int, int>();
            foreach (var fruit in fruits)
            {
                if (!lookup.ContainsKey(fruit))
                {
                    lookup.Add(fruit, 0);
                }
                lookup[fruit] += 1;
            }
            if (lookup.Keys.Count <= 2)
            {
                return lookup.Values.Sum();
            }

            foreach (var item in lookup)
            {

            }
            return firstMax + secondMax;
        }
    }
}
