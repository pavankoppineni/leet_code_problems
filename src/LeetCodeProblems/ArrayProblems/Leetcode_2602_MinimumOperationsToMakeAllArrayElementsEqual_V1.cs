using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-make-all-array-elements-equal/
    /// </summary>
    public class Leetcode_2602_MinimumOperationsToMakeAllArrayElementsEqual_V1
    {
        private int[] _nums;
        public int[] CalculateMinimumOperations(int[] nums, int[] queries)
        {
            var operations = new int[queries.Length];
            Array.Sort(nums);
            return operations;
        }

        private int BinarySearch(int start, int end, int queryValue)
        {
            return -1;
        }
    }
}
