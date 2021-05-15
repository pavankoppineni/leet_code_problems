using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MathProblems
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class Leetcode_9_PalindromeNumber_V1
    {
        public bool IsPalindrome(int number)
        {
            var duplicateNumber = number;
            if (number == 0)
            {
                return true;
            }

            if (number < 0)
            {
                number *= -1;
            }

            var newNumber = 0;
            while (number > 0)
            {
                var reminder = number % 10;
                newNumber = newNumber * 10 + reminder;
                number /= 10;
            }

            if (duplicateNumber == newNumber)
            {
                return true;
            }
            return false;
        }
    }
}
