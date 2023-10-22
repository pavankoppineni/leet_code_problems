using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-it-is-possible-to-split-array/
    /// </summary>
    public class Leetcode_2811_CheckIfItIsPossibleToSplitArray_V1
    {
        public bool CanArraySplit(int[] values, int m)
        {
            var sum = values.Sum();
            var left = 0;
            var right = values.Length - 1;
            while (left < right)
            {
                var sumWithoutLeft = sum - left;
                var sumWithoutRight = sum - right;
                if (sumWithoutLeft < m)
                {
                    if (sumWithoutRight < m)
                    {
                        return false;
                    }
                    sum = sumWithoutRight;
                    right--;
                    continue;
                }

                if (sumWithoutRight < m)
                {
                    sum = sumWithoutLeft;
                    left++;
                    continue;
                }

                if (sumWithoutRight > sumWithoutLeft)
                {
                    sum = sumWithoutRight;
                    right--;
                }
                else
                {
                    sum = sumWithoutLeft;
                    left++;
                }
            }
            return sum >= m;
        }
    }
}
