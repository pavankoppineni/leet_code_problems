using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.RecursionProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-punishment-number-of-an-integer/
    /// </summary>
    public class Leetcode_2698_FindThePunishmentNumberOfAnInteger_V1
    {
        public int CalculatePunishmentNumber(int number)
        {
            return 0;
        }

        public bool IsPunishmentNumber(int number, int target)
        {
            if (number < 10)
            {
                return number == target;
            }

            if (number == 0 && target > 0)
            {
                return false;
            }

            if(target < 0)
            {
                return false;
            }

            if (number == 0 && target == 0)
            {
                return true;
            }

            var exponent = 1;
            while (true)
            {
                var denominator = (int)Math.Pow(10, exponent);
                var reminder = number % denominator;
                var result = number / denominator;
                if (IsPunishmentNumber(result, target - reminder))
                {
                    return true;
                }
                exponent += 1;
                if (result <= 0)
                {
                    break;
                }
            }
            return false;
        }
    }
}
