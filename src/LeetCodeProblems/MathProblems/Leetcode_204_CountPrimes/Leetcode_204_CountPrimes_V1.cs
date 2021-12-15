using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MathProblems.Leetcode_204_CountPrimes
{
    /// <summary>
    /// https://leetcode.com/problems/count-primes/
    /// </summary>
    public class Leetcode_204_CountPrimes_V1
    {
        public int CountPrimes(int n)
        {
            var validPrimes = new bool[n + 1];
            for (var i = 2; i <= n; i++)
            {
                if (!validPrimes[i])
                {
                    for (var j = i * i; j <= n; j += i)
                    {
                        validPrimes[j] = true;
                    }
                }
            }
            var count = 0;
            for (var i = 2; i <= n; i++)
            {
                if (!validPrimes[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
