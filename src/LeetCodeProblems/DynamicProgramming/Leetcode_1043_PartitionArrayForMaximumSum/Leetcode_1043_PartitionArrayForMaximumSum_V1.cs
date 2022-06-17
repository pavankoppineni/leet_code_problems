using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_1043_PartitionArrayForMaximumSum
{
    /// <summary>
    /// https://leetcode.com/problems/partition-array-for-maximum-sum/
    /// </summary>
    public class Leetcode_1043_PartitionArrayForMaximumSum_V1
    {
        private int[] _values;
        private int _size;
        private IDictionary<int, int> _lookup;
        public int CalculateMaximumSum(int[] values, int size)
        {
            _lookup = new Dictionary<int, int>();
            _values = values;
            _size = size;
            return 0;
        }
    }
}
