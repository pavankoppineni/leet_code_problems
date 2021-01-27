using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// </summary>
    public class Leetcode_31_NextPermutation_V2
    {
        public int[] FindNextPermutation(int[] values)
        {
            var breakIndex = -1;
            for (var index = values.Length - 2; index >= 0; index--)
            {
                //Case 1 : When current item is greater than previous item
                if (values[index] >= values[index + 1])
                {
                    continue;
                }
                else
                {
                    breakIndex = index;
                    break;
                }
            }

            if (breakIndex == -1)
            {
                return ReverseArray(values, 0);
            }

            var higherValueIndex = FindIndex(values, breakIndex + 1, values.Length - 1, values[breakIndex]);
            var temp = values[higherValueIndex];
            values[higherValueIndex] = values[breakIndex];
            values[breakIndex] = temp;

            return ReverseArray(values, breakIndex + 1);
        }

        private int[] ReverseArray(int[] values, int startIndex)
        {
            var endIndex = values.Length - 1;
            while (startIndex < endIndex)
            {
                var temp = values[endIndex];
                values[endIndex] = values[startIndex];
                values[startIndex] = temp;
                startIndex += 1;
                endIndex -= 1;
            }
            return values;
        }

        private int FindIndex(int[] values, int start, int end, int value)
        {
            if (start == end)
            {
                return start;
            }

            var mid = (start + end) >> 1;
            //Case 1 : Value is greater than mid
            if (value > values[mid])
            {
                return FindIndex(values, start, mid - 1, value);
            }
            //Case 2 : Value is less than mid
            return FindIndex(values, mid, end, value);
        }
    }
}
