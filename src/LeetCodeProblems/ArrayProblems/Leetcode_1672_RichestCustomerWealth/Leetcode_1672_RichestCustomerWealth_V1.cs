using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1672_RichestCustomerWealth
{
    /// <summary>
    /// https://leetcode.com/problems/richest-customer-wealth/
    /// </summary>
    public class Leetcode_1672_RichestCustomerWealth_V1
    {
        public int CalculateMaximumWealth(int[][] accounts)
        {
            var maxWealth = 0;
            foreach (var account in accounts)
            {
                var currentMax = 0;
                foreach (var item in account)
                {
                    currentMax += item;
                }
                if (currentMax > maxWealth)
                {
                    maxWealth = currentMax;
                }
            }
            return maxWealth;
        }
    }
}
