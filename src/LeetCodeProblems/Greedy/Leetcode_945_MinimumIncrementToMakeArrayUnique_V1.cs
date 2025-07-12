using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-increment-to-make-array-unique/description/?envType=problem-list-v2&envId=greedy
    /// </summary>
    public class Leetcode_945_MinimumIncrementToMakeArrayUnique_V1
    {
        public int Calculate(int[] nums)
        {
            Array.Sort(nums);
            var numberOfIncrements = 0;
            for (var index = 1; index < nums.Length; index++)
            {
                if (nums[index] <= nums[index - 1])
                {
                    var diff = nums[index - 1] - nums[index];
                    nums[index] = nums[index] + diff + 1;
                    numberOfIncrements += diff + 1;
                }
            }
            return numberOfIncrements;
        }
    }
}
