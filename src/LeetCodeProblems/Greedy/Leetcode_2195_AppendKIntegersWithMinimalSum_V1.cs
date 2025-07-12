using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/append-k-integers-with-minimal-sum/description/
    /// </summary>
    public class Leetcode_2195_AppendKIntegersWithMinimalSum_V1
    {
        public long CalculateMinumalSum(int[] nums, int k)
        {
            long sum = 0;
            Array.Sort(nums);
            var start = 1;
            var previous = 0;
            for (var index = 0; index < nums.Length && k > 0;)
            {
                var value = nums[index];
                if (value == previous)
                {
                    previous = value;
                    index++;
                    continue;
                }

                // Case 1
                // When : value is equal to start
                // Then : increment start and index
                if (value == start)
                {
                    start++;
                    index++;
                    previous = value;
                    continue;
                }

                // Case 2
                // when : value is not equal to start
                // Then : 
                var diff = value - previous;
            }

            return sum;
        }
    }
}
