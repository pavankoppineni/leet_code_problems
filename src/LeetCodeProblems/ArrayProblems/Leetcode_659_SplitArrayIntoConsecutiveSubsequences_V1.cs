using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/split-array-into-consecutive-subsequences/
    /// </summary>
    public class Leetcode_659_SplitArrayIntoConsecutiveSubsequences_V1
    {
        public bool CanSplitArray(int[] numbers)
        {
            var numberLookup = ConstructLookup(numbers);
            return false;
        }

        private IDictionary<int, int> ConstructLookup(int[] numbers)
        {
            var numberLookup = new Dictionary<int, int>();
            for (var index = 0; index < numbers.Length; index++)
            {
                var number = numbers[index];
                if (!numberLookup.ContainsKey(number))
                {
                    numberLookup.Add(number, 0);
                }
                numberLookup[number] += 1;
            }
            return numberLookup;
        }
    }
}
