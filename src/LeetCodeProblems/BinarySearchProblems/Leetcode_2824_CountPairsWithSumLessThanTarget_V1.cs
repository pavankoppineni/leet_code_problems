using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target
    /// </summary>
    public class Leetcode_2824_CountPairsWithSumLessThanTarget_V1
    {
        public int CountPairs(IList<int> nums, int target)
        {
            var sortedList = new SortedList<int, int>();
            sortedList.Add(nums[0], nums[0]);
            var pairs = 0;
            for (var index = 1; index < nums.Count; index++)
            {
                var remaining = target - nums[index];
                pairs += CalculatePairs(sortedList, remaining, 0, index - 1);
                sortedList.Add(nums[index], nums[index]);
            }
            return pairs;
        }

        private int CalculatePairs(SortedList<int, int> numbers, int remaining, int start, int end)
        {
            if (start == end)
            {
                return start;
            }

            if (start > end)
            {
                return 0;
            }

            if (end - start == 1)
            {
                return end;
            }

            var midValue = (end - start) / 2;
            var midIndex = start + midValue;
            if (numbers.GetValueAtIndex(midIndex) >= remaining)
            {
                return CalculatePairs(numbers, remaining, start, midIndex - 1);
            }

            return CalculatePairs(numbers, remaining, midIndex, end);
        }
    }
}
