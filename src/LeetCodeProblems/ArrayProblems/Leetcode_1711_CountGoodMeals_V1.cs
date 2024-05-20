using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    public class Leetcode_1711_CountGoodMeals_V1
    {
        public int CalculateCountGoodMeals(int[] meals)
        {
            var lookup = ConstructLookup(meals);
            return CalculatePairs(lookup);
        }

        private int CalculatePairs(IDictionary<int, MealItem> lookup)
        {
            var count = 0;
            foreach (var pair in lookup)
            {
                var value = pair.Value;
                var diff = value.NextPower - pair.Key;
                if (lookup.ContainsKey(diff))
                {
                    count += lookup[diff].Count;
                }
            }
            return count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="meals"></param>
        /// <returns></returns>
        private IDictionary<int, MealItem> ConstructLookup(int[] meals)
        {
            var lookup = new Dictionary<int, MealItem>();
            foreach (var mealItem in meals)
            {
                if (lookup.ContainsKey(mealItem))
                {
                    lookup[mealItem].Count += 1;
                    continue;
                }
                var nextPower = CalculateNextPowerOfTwo(mealItem);
                lookup.Add(mealItem, new MealItem { Count = 1, NextPower = nextPower });
            }
            return lookup;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int CalculateNextPowerOfTwo(int value)
        {
            var leftShift = 0;
            var powerOfTwo = 1 << leftShift;
            while (powerOfTwo < value)
            {
                leftShift++;
                powerOfTwo = 1 << leftShift;
            }
            return powerOfTwo;
        }

        /// <summary>
        /// 
        /// </summary>
        internal class MealItem
        {
            internal int Count { get; set; }
            internal int NextPower { get; set; }
        }
    }
}
