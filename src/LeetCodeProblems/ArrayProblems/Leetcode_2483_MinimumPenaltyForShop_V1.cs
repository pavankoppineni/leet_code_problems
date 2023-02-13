using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-penalty-for-a-shop/
    /// </summary>
    public class Leetcode_2483_MinimumPenaltyForShop_V1
    {
        public int CalculateBestClosingTime(string customers)
        {
            var totalHours = customers.Length;
            var totalCustomerVisitCount = 0;
            foreach (var customer in customers)
            {
                if (customer == 'Y')
                {
                    totalCustomerVisitCount += 1;
                }
            }

            var customerVisitsCount = 0;
            var minimumPenalty = 0;
            for (var hour = 0; hour < customers.Length; hour++)
            {
                var currentPenalty = 0;
                customerVisitsCount += 1;
                var noCustomerVisits = hour + 1 - customerVisitsCount;
                currentPenalty = noCustomerVisits + totalCustomerVisitCount - customerVisitsCount;
                minimumPenalty = Math.Min(minimumPenalty, currentPenalty);
            }
            return minimumPenalty;
        }
    }
}
