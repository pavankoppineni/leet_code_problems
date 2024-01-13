using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-there-is-a-valid-partition-for-the-array/
    /// </summary>
    public class Leetcode_2369_CheckIfThereIsValidPartitionForTheArray_V1
    {
        private int[] _nums;
        private IDictionary<int, bool> _partitionLookup;
        public bool PartitionExists(int[] nums)
        {
            _partitionLookup = new Dictionary<int, bool>();
            _nums = nums;
            return PartitionExists(0);
        }

        private bool PartitionExists(int start)
        {
            if (_partitionLookup.ContainsKey(start))
            {
                return _partitionLookup[start];
            }

            if (start >= _nums.Length)
            {
                return true;
            }

            if (_nums.Length - start == 1)
            {
                return false;
            }

            if (_nums.Length - start == 2)
            {
                return _nums[start] == _nums[start + 1];
            }

            var first = _nums[start];
            var second = _nums[start + 1];
            var third = _nums[start + 2];

            if(second - first > 1)

            if (first == second)
            {
                if (PartitionExists(start + 2))
                {
                    _partitionLookup.Add(start, true);
                    return true;
                }

                if (second == third)
                {
                    if (PartitionExists(start + 3))
                    {
                        _partitionLookup.Add(start, true);
                        return true;
                    }
                }
                return false;
            }

            if (first + 1 == second && second + 1 == third)
            {
                if (PartitionExists(start + 3))
                {
                    _partitionLookup.Add(start, true);
                    return true;
                }
            }

            _partitionLookup.Add(start, false);
            return false;
        }
    }
}
