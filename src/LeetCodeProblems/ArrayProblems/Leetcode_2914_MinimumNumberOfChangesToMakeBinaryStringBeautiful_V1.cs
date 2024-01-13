using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-changes-to-make-binary-string-beautiful/
    /// </summary>
    public class Leetcode_2914_MinimumNumberOfChangesToMakeBinaryStringBeautiful_V1
    {
        public int CalculateMinimumNumberOfChanges(string binaryString)
        {
            var minChanges = 0;
            var index = 1;
            while (index < binaryString.Length)
            {
                if (binaryString[index] != binaryString[index - 1])
                {
                    minChanges += 1;
                }
                index += 2;
            }
            return minChanges;
        }
    }
}
