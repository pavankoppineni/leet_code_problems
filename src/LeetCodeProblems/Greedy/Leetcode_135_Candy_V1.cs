using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/candy/
    /// </summary>
    public class Leetcode_135_Candy_V1
    {
        public int CalculateMinimumNumberOfCandies(int[] children)
        {
            var candies = new int[children.Length];
            for (var index = 0; index < children.Length; index++)
            {
                candies[index] = 1;
            }

            //Case 1 : Calculate candies from left to right
            for (var index = 1; index < children.Length; index++)
            {
                var previous = children[index - 1];
                var current = children[index];

                //When : current is greater than previous
                //Then : assign current candy count as previous candy count + 1
                if (current > previous)
                {
                    candies[index] = candies[index - 1] + 1;
                }
            }

            //Case 2 : Calculate candies from right to left
            for (var index = children.Length - 2; index >= 0; index--)
            {
                var next = children[index + 1];
                var current = children[index];

                //When : current is greater than next
                //Then : check if current candy count is greater than next candy count
                if (current > next)
                {
                    //When : current candy count is less than or equal to next candy count
                    //Then : Increment candy count
                    if (candies[index] <= candies[index + 1])
                    {
                        candies[index] = candies[index + 1] + 1;
                    }
                }
            }
            return candies.Sum();
        }
    }
}
