using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/beautiful-arrangement-ii/
    /// </summary>
    public class Leetcode_667_BeautifulArrangementII_V1
    {
        private bool found;
        private int[] values;
        private HashSet<int> cnt;
        public int[] ConstructArray(int n, int k)
        {
            values = new int[n];
            var currentValue = 1;
            for (var index = 0; index < values.Length; index++)
            {
                values[index] = currentValue;
                currentValue += 1;
            }
            PrepareForArrangement(0, k);
            if (found == true)
            {
                return values;
            }
            return null;
        }

        private void PrepareForArrangement(int startIndex, int k)
        {
            if (startIndex == values.Length)
            {
                found = true;
                return;
            }
            for (var index = startIndex; index < values.Length; index++)
            {
                if (startIndex > 0)
                {
                    var diff = Math.Abs(values[startIndex - 1] - values[index]);
                    cnt.Add(diff);
                    if (cnt.Count > k)
                    {
                        continue;
                    }
                }
                Swap(startIndex, index);
                PrepareForArrangement(startIndex + 1, k);
                Swap(startIndex, index);
            }
        }

        private void Swap(int i, int j)
        {
            var temp = values[i];
            values[i] = values[j];
            values[j] = temp;
        }
    }
}
