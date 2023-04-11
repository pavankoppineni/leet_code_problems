using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/the-number-of-beautiful-subsets/
    /// </summary>
    public class Leetcode_2597_TheNumberOfBeautifulSubsets_V1
    {
        private int[] _values;
        private int _difference;
        public int CalculateNumberOfBeautifulSubsets(int[] values, int difference)
        {
            _difference = difference;
            _values = values;
            return 0;
        }
    }
}
