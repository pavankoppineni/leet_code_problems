using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/grumpy-bookstore-owner/
    /// </summary>
    public class Leetcode_1052_GrumpyBookstoreOwner_V1
    {
        public int CalculateMaximumSatisfiedCustomers(int[] customers, int[] grumpy, int minutes)
        {
            var currentSatisfiedCustomers = 0;
            var maxSatisifiedCustomers  = 0;
            for (var index = 0; index < customers.Length; index++)
            {
                if (grumpy[index] == 1)
                {
                    continue;
                }
                currentSatisfiedCustomers += customers[index];
            }

            for (var minute = 0; minute < minutes; minute++)
            {
                if (grumpy[minute] == 1)
                {
                    currentSatisfiedCustomers += customers[minute];
                }
            }
            maxSatisifiedCustomers = currentSatisfiedCustomers;

            for (var minute = minutes; minute < grumpy.Length; minute++)
            {
                var leftEndMinute = minute - minutes;
                if (grumpy[minute] == 1)
                {
                    currentSatisfiedCustomers += customers[minute];
                }

                if (grumpy[leftEndMinute] == 1)
                {
                    currentSatisfiedCustomers -= customers[leftEndMinute];
                }

                maxSatisifiedCustomers = Math.Max(maxSatisifiedCustomers, currentSatisfiedCustomers);
            }
            return maxSatisifiedCustomers;
        }
    }
}
