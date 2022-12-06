using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-of-distinct-subarrays-with-length-k/
    /// </summary>
    public class Leetcode_2461_MaximumSumOfDistinctSubarraysWithLengthK_V1
    {
        public int CalculateMaximumSubArraySum(int[] values, int subArrayLength)
        {
            if(subArrayLength == 1)
            {
                return values.Max();
            }

            var maxSubArraySum = 0;
            var valuesLookup = new Dictionary<int, int>();
            var prefixSum = ConstructSubarraySumLookup(values, subArrayLength);
            var startIndex = 0;
            valuesLookup.Add(values[0], 0);
            for (var index = 1; index < values.Length; index++)
            {
                var value = values[index];

                //When : Value exists in lookup
                //Then : Check index is less than startIndex
                if (valuesLookup.ContainsKey(value))
                {
                    var valueIndex = valuesLookup[value];

                    //When : valueIndex is less than startIndex
                    //Then : Update valueIndex to index in lookup
                    if (valueIndex < startIndex)
                    {
                        valuesLookup[value] = valueIndex;
                    }
                    //When : valueIndex is greater than startIndex
                    //Then : update startIndex to valueIndex + 1
                    else
                    {
                        startIndex = valueIndex + 1;
                        valuesLookup[value] = index;
                    }
                }
                //When : Value doesn't exist in lookup
                //Then : Add value to lookup
                else
                {
                    valuesLookup.Add(value, index);
                }

                //When : subArray length is equal to subArrayLength
                if (index - startIndex + 1 == subArrayLength)
                {
                    var sumDeduction = 0;
                    if (startIndex > 0)
                    {
                        sumDeduction = prefixSum[startIndex - 1];
                    }
                    maxSubArraySum = Math.Max(maxSubArraySum, prefixSum[index] - sumDeduction);
                    startIndex += 1;
                }
            }

            return maxSubArraySum;
        }

        /// <summary>
        /// Calculates prefix sum array
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private IDictionary<int, int> ConstructSubarraySumLookup(int[] values, int subArrayLength)
        {
            throw new NotImplementedException();
        }
    }
}
