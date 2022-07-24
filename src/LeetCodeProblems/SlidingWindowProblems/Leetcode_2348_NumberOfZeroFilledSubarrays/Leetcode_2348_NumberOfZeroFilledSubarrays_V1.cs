using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems.Leetcode_2348_NumberOfZeroFilledSubarrays
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-zero-filled-subarrays/
    /// </summary>
    public class Leetcode_2348_NumberOfZeroFilledSubarrays_V1
    {
        public long CalculateNumberOfSubArrays(int[] values)
        {
            var start = -1;
            long count = 0;
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                //Case 1 : When value is 0
                if (value == 0)
                {
                    if (start == -1)
                    {
                        start = index;
                    }
                    var len = index - start + 1;
                    count += len;
                    continue;
                }
                start = -1;
            }

            return count;
        }
    }
}
