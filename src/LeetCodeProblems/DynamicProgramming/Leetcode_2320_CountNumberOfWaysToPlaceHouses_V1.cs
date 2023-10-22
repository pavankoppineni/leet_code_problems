using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/count-number-of-ways-to-place-houses/
    /// </summary>
    public class Leetcode_2320_CountNumberOfWaysToPlaceHouses_V1
    {
        public int CalculateNumberOfPlacements(int plots)
        {
            if (plots <= 1)
            {
                return 4;
            }

            (long inclusive, long exclusive) previousWays = (1, 1);
            for (var index = 1; index < plots; index++)
            {
                var inclusive = previousWays.exclusive;
                var exclusive = previousWays.exclusive + previousWays.inclusive;
                previousWays = (inclusive, exclusive);
            }
            long numberOfWays = previousWays.exclusive + previousWays.inclusive;
            var denominator = Math.Pow(10, 9) + 7;
            return (int)((numberOfWays * numberOfWays) % denominator);
        }
    }
}
