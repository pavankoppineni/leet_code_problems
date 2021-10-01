using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/continuous-subarray-sum/
    /// </summary>
    public class Leetcode_523_ContinuousSubarraySum_V1
    {
        public bool CheckSubArraySum(int[] values, int k)
        {
            var result = false;
            //Step 1 : Calculate modulo of all items in an array
            for (var index = 0; index < values.Length; index++)
            {
                values[index] = values[index] % k;
            }

            //Step 2 : Calculate prefix sum
            var prefixSum = new int[values.Length];
            prefixSum[0] = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                prefixSum[index] = prefixSum[index - 1] + values[index];
            }

            //Step 3 : Construct dictionary and find subarray
            var hashSet = new Dictionary<int, IList<int>>();
            for (var index = 0; index < values.Length; index++)
            {
                var value = prefixSum[index];
                if (value % k == 0)
                {
                    result = true;
                    break;
                }
                var offset = value - k;
                if (hashSet.ContainsKey(offset))
                {
                    result = true;
                    break;
                }
                if (hashSet.ContainsKey(value))
                {
                    hashSet[value].Add(index);
                }
                else
                {
                    hashSet.Add(value, new List<int> { index });
                }
            }
            return result;
        }
    }
}
