using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-ways-to-select-buildings/
    /// </summary>
    public class Leetcode_2222_NumberOfWaysToSelectBuildings_V1
    {
        public long CalculateNumberOfWays(string building)
        {
            var prefixSum = new (int officeCount, int restaurantCount)[building.Length];
            if (building[0] == '0')
            {
                prefixSum[0].officeCount = 1;
            }
            else
            {
                prefixSum[0].restaurantCount = 1;
            }

            for (var index = 1; index < building.Length; index++)
            {
                if (building[index] == '0')
                {
                    prefixSum[index].officeCount = prefixSum[index - 1].officeCount + 1;
                    prefixSum[index].restaurantCount = prefixSum[index - 1].restaurantCount;
                }
                else
                {
                    prefixSum[index].officeCount = prefixSum[index - 1].officeCount;
                    prefixSum[index].restaurantCount = prefixSum[index - 1].restaurantCount + 1;
                }
            }

            var totalCount = prefixSum[building.Length - 1];
            long maximumWays = 0;
            for (var index = 1; index < building.Length - 1; index++)
            {
                var previousCount = prefixSum[index - 1];
                var countSofar = prefixSum[index];
                var remainingCount = (officeCount: totalCount.officeCount - countSofar.officeCount, restaurantCount: totalCount.restaurantCount - countSofar.restaurantCount);
                if (building[index] == '0')
                {
                    maximumWays += previousCount.restaurantCount * remainingCount.restaurantCount;
                }
                else
                {
                    maximumWays += previousCount.officeCount * remainingCount.officeCount;
                }
            }

            return maximumWays;
        }
    }
}
