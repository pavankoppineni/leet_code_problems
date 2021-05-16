using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/largest-number/
    /// </summary>
    public class Leetcode_179_LargestNumber_V1
    {
        public string FindLargestNumber(int[] values)
        {
            var strings = new string[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                strings[index] = values[index].ToString();
            }
            Array.Sort(strings, new LargestNumberComparable());
            var result = string.Empty;
            for (var index = strings.Length - 1; index >= 0; index--)
            {
                result += strings[index];
            }
            if (result[0] == '0')
            {
                return "0";
            }
            return result;
        }

        public class LargestNumberComparable : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return (x + y).CompareTo(y + x);
            }
        }
    }
}
