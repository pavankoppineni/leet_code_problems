using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/bag-of-tokens/
    /// </summary>
    public class Leetcode_948_BagOfTokens_V1
    {
        public int CalculateScore(int[] tokens, int power)
        {
            var maxScore = 0;
            Array.Sort(tokens);
            var start = 0;
            var end = tokens.Length - 1;
            var currentScore = 0;
            while (start <= end)
            {
                var currentPower = tokens[start];
                //When : Power is greater than or equal to current power
                //Then : Increment score
                if (power >= currentPower)
                {
                    power -= currentPower;
                    currentScore += 1;
                    start += 1;
                }
                else
                {
                    //When : Score is less than or equal to zero
                    //Then : Terminate
                    if (currentScore <= 0)
                    {
                        break;
                    }
                    power += tokens[end];
                    currentScore -= 1;
                    end -= 1;
                }

                if (currentScore >= maxScore)
                {
                    maxScore = currentScore;
                }
            }
            return maxScore;
        }
    }
}
