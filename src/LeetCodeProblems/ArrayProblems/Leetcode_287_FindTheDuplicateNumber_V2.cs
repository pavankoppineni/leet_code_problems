using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    public class Leetcode_287_FindTheDuplicateNumber_V2
    {
        public int FindDuplicateNumber(int[] numbers)
        {
            var duplicateNumber = -1;
            var length = numbers.Length;
            for (var i = 0; i < length; i++)
            {
                var currentNumber = Math.Abs(numbers[i]);
                var value = numbers[currentNumber - 1];

                //Case 1 : Number is negative
                if (value < 0)
                {
                    duplicateNumber = currentNumber;
                    break;
                }
                //Case 2 : Number is not negative
                else
                {
                    numbers[currentNumber - 1] = -1 * numbers[currentNumber - 1];
                }
            }

            return duplicateNumber;
        }
    }
}
