using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    public class Leetcode_287_FindTheDuplicateNumber_V3
    {
        public int FindDuplicateNumber(int[] values)
        {
            var duplicateNumber = 0;
            for (var index = 0; index < values.Length; index++)
            {
                var itemIndex = Math.Abs(values[index]);
                var indexValue = values[itemIndex];
                if (indexValue < 0)
                {
                    duplicateNumber = itemIndex;
                    break;
                }
                else
                {
                    values[itemIndex] = -1 * values[itemIndex];
                }
            }
            return duplicateNumber;
        }
    }
}
