using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    /// </summary>
    public class Leetcode_1299_ReplaceElementWithGreatestElementOnRightSide_V1
    {
        public int[] ReplaceElements(int[] values)
        {
            //Case 1 : When array size is one
            //Action : Replace array value with -1
            if (values.Length == 1)
            {
                values[0] = -1;
                return values;
            }

            var len = values.Length;
            var max = -1;
            for (var index = len - 1; index >= 0; index--)
            {
                var currentValue = values[index];
                values[index] = max;
                if (currentValue > max)
                {
                    max = currentValue;
                }
            }

            return values;
        }
    }
}
