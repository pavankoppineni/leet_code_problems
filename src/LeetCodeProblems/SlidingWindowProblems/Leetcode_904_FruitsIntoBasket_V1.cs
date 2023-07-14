using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/fruit-into-baskets/
    /// </summary>
    public class Leetcode_904_FruitsIntoBasket_V1
    {
        public int CalculateMaximumFruits(int[] fruits)
        {
            var maxFruits = 0;
            var lookup = new Dictionary<int, int>();
            for(var index = 0; index < fruits.Length; index++)
            {
                var fruit = fruits[index];
                //When : Fruit exists in lookup
                if(lookup.ContainsKey(fruit))
                {
                    lookup[fruit] = index;
                    maxFruits += 1;
                }
                //When : Fruit does not exist in lookup
                else
                {
                   //When : Lookup count is less than 2
                    if(lookup.Count < 2)
                    {
                        lookup.Add(fruit, index);
                        maxFruits += 1;
                    }
                    //When : Lookup count is greater than or equal to 2
                    else
                    {

                    }
                }
            }
            return maxFruits;        
        }
    }
}
