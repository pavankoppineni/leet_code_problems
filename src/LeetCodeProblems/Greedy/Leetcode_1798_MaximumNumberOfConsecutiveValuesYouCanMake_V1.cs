using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-consecutive-values-you-can-make/
    /// </summary>
    public class Leetcode_1798_MaximumNumberOfConsecutiveValuesYouCanMake_V1
    {
        public int CalculateMaximumConsecutiveNumbers(int[] coins)
        {
            var maximumConsecutiveNumbers = 0;
            Array.Sort(coins);
            foreach (var coin in coins)
            {
                //When : coin is greater than maximumConsecutiveNumbers
                //Then : 
                if (coin > maximumConsecutiveNumbers)
                {
                    if (coin - maximumConsecutiveNumbers > 1)
                    {
                        break;
                    }
                }
                maximumConsecutiveNumbers += coin;
            }
            return maximumConsecutiveNumbers;
        }
    }
}
