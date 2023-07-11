using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-distance-between-a-pair-of-values/
    /// </summary>
    public class Leetcode_1855_MaximumDistanceBetweenPairOfValues_V1
    {
        public int CalculateMaximumDistance(int[] arrayOne, int[] arrayTwo)
        {
            var maximumValue = 0;
            var i = arrayOne.Length - 1;
            var j = arrayTwo.Length - 1;
            while (i >= 0 && j >= 0)
            {
                var leftValue = arrayOne[i];
                var rightValue = arrayTwo[j];

                //When : Left value is less than or equal to right value
                //Then : Decrement left index
                if (leftValue <= rightValue)
                {
                    maximumValue = Math.Max(maximumValue, j - i);
                    i--;
                }

                //When : Left values is greater than right value
                //Then : Decrement right index
                else
                {
                    j--;
                }
            }
            return maximumValue;
        }
    }
}
