using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-number-of-distinct-integers-after-reverse-operations/
    /// </summary>
    public class Leetcode_CountNumberofDistinctIntegersAfterReverseOperations_V1
    {
        public int CalculateDistinctNumbers(int[] nums)
        {
            var distinctNumbers = new HashSet<int>();
            foreach (var number in nums)
            {
                distinctNumbers.Add(number);
                distinctNumbers.Add(ReverseNumber(number));
            }
            return distinctNumbers.Count;
        }

        private int ReverseNumber(int num)
        {
            var result = 0;
            while (num > 0)
            {
                var reminder = num % 10;
                result = (result * 10) + reminder;
                num /= 10;
            }
            return result;
        }
    }
}
