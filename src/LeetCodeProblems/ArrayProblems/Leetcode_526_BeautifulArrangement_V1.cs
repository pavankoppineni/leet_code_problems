using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/beautiful-arrangement/
    /// </summary>
    public class Leetcode_526_BeautifulArrangement_V1
    {
        private int[] values;
        private int count = 0;
        public int CountArrangement(int n)
        {
            values = new int[n + 1];
            for (var index = 1; index < values.Length; index++)
            {
                values[index] = index;
            }
            GeneratePermutations(1);
            return count;
        }

        private void GeneratePermutations(int start)
        {
            if (start == values.Length)
            {
                count += 1;
            }
            for (var index = start; index < values.Length; index++)
            {
                var caseOne = values[index] % start;
                var caseTwo = start % values[index];
                if (Math.Min(caseTwo, caseOne) != 0)
                {
                    continue;
                }
                Swap(start, index);
                GeneratePermutations(start + 1);
                Swap(start, index);
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
