using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/max-number-of-k-sum-pairs/
    /// </summary>
    public class Leetcode_1679_MaximumNumberOfKSumPairs_V1
    {
        public int FindPairs(int[] values, int sum)
        {
            //Case X : When length of array is one
            //Action : Return ZERO
            if (values.Length == 1)
            {
                return 0;
            }

            if (values.Length == 2)
            {
                if (sum == values[0] + values[1])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            var count = 0;
            var dict = new Dictionary<int, int>();
            for (var index = 0; index < values.Length; index++)
            {
                var target = sum - values[index];
                //Case A : When target is present in dictionary
                //Action : Remove target from dict or decrement value
                if (dict.ContainsKey(target))
                {
                    count += 1;
                    var targetCount = dict[target];
                    if (targetCount > 1)
                    {
                        dict[target] -= 1;
                    }
                    else
                    {
                        dict.Remove(target);
                    }
                }
                //Case B : When target is not present in dictionary
                //Action : Increment value or add value
                else
                {
                    //Case 1 : When value is present in dict
                    //Action : Increment value
                    if (dict.ContainsKey(values[index]))
                    {
                        dict[values[index]] += 1;
                    }
                    //Case 2 : When value is not present
                    //Action : Add value
                    else
                    {
                        dict.Add(values[index], 1);
                    }
                }
            }
            return count;
        }
    }
}
