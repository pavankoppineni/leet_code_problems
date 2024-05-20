using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-of-almost-unique-subarray/
    /// </summary>
    public class Leetcode_2841_MaximumSumOfAlmostUniqueSubarray_V1
    {
        public long CalculateMaximumSum(IList<int> nums, int uniqueCount, int subArraySize)
        {
            var countLookup = new Dictionary<int, int>();
            var maxSum = 0;
            var sumSoFar = 0;
            for (var index = 0; index < subArraySize; index++)
            {
                var number = nums[index];
                if (!countLookup.ContainsKey(number))
                {
                    countLookup.Add(number, 0);
                }
                countLookup[number] += 1;
                sumSoFar += number;
            }
            if (countLookup.Count >= uniqueCount)
            {
                maxSum = sumSoFar;
            }
            var start = 0;
            var end = subArraySize;
            while (end < nums.Count)
            {
                var numberToAdd = nums[end];
                var numberToRemove = nums[start];
                countLookup[numberToRemove] -= 1;

                //When : numberToAdd is not present in lookup
                if (!countLookup.ContainsKey(numberToAdd))
                {
                    countLookup.Add(numberToAdd, 0);
                }
                countLookup[numberToAdd] += 1;

                //When : numberToRemove count is ZERO
                if (countLookup[numberToRemove] == 0)
                {
                    countLookup.Remove(numberToRemove);
                }
                sumSoFar -= numberToRemove;
                sumSoFar += numberToAdd;

                //When : count of entries in lookup is equal to uniqueCount
                if (countLookup.Count >= uniqueCount)
                {
                    maxSum = Math.Max(maxSum, sumSoFar);
                }
                start += 1;
                end += 1;
            }
            return maxSum;
        }
    }
}
