using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/distribute-candies-among-children-ii/
    /// </summary>
    public class Leetcode_2929_DistributeCandiesAmongChildren_II_V1
    {
        public long CalculateNumberOfWays(int numberOfCandies, int limit)
        {
            long numberOfWays = 0;
            var minLimit = Math.Min(numberOfCandies, limit);
            while (minLimit >= 0)
            {
                var remainingCandies = numberOfCandies - minLimit;

                //When : remainingCandies is greater than 2*limit
                //Then : No way to divide
                if (remainingCandies > 2 * limit)
                {
                    minLimit--;
                    continue;
                }

                //When : remaining is less than or equal to 2 * limit
                var diff = Math.Abs(remainingCandies - limit);
                numberOfWays += Math.Abs(diff - limit) + 1;
                minLimit--;
            }
            return numberOfWays;
        }
    }
}
