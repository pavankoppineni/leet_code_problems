using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// </summary>
    public class Leetcode_31_NextPermuation_V3
    {
        public int[] GetNextPermutation(int[] values)
        {
            var breakIndex = FindBreakIndex(values);
            if (breakIndex == -1)
            {
                return values;
            }
            var greaterIndex = FindGreaterIndex(values, breakIndex);
            Swap(values, breakIndex, greaterIndex);
            Reverse(values, breakIndex + 1, values.Length - 1);
            return values;
        }

        private void Reverse(int[] values, int start, int end)
        {
            if (start == end)
            {
                return;
            }
            while (start < end)
            {
                var temp = values[start];
                values[start] = values[end];
                values[end] = temp;
                start += 1;
                end -= 1;
            }
        }

        private void Swap(int[] values, int i, int j)
        {
            var temp = values[i];
            values[i] = values[j];
            values[j] = temp;
        }

        private int FindGreaterIndex(int[] values, int breakIndex)
        {
            var greaterIndex = -1;
            for (var index = values.Length - 1; index > breakIndex; index--)
            {
                if (values[breakIndex] >= values[index])
                {
                    continue;
                }
                else
                {
                    greaterIndex = index;
                    break;
                }
            }
            return greaterIndex;
        }

        private int FindBreakIndex(int[] values)
        {
            var breakIndex = -1;
            for (var index = values.Length - 2; index >= 0; index--)
            {
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
            return breakIndex;
        }

    }
}
