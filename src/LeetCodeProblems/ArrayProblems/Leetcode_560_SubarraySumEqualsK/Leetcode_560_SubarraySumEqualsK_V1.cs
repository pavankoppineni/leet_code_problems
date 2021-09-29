using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/subarray-sum-equals-k/
    /// </summary>
    public class Leetcode_560_SubarraySumEqualsK_V1
    {
        public int FindNumberOfSubarrays(int[] values, int k)
        {
            var count = 0;
            var currentPinter = -1;
            var sum = 0;
            for (var index = 0; index < values.Length; index++)
            {
                var currentSum = sum + values[index];
                //Case 1 : Current sum is greater than k
                if (currentSum > k)
                {
                    if (currentPinter == -1)
                    {
                        continue;
                    }
                    while(currentPinter <= index)
                    {
                        currentSum -= values[currentPinter];
                        if (currentSum > k)
                        {
                            currentPinter += 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                //Case 2 : Current sum is less than k
                else if (currentSum < k)
                {
                    if (currentPinter == -1)
                    {
                        currentPinter = index;
                    }
                    sum = currentSum;
                    continue;
                }
                if(currentSum == k)
                {
                }
            }
            return count;
        }
    }
}
