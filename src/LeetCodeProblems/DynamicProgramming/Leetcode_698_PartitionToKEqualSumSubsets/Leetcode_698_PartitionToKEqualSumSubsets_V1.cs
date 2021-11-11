using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_698_PartitionToKEqualSumSubsets
{
    /// <summary>
    /// https://leetcode.com/problems/partition-to-k-equal-sum-subsets/
    /// </summary>
    public class Leetcode_698_PartitionToKEqualSumSubsets_V1
    {
        public bool CanPartitionKSubsets(int[] values, int partitions)
        {
            var sum = values.Sum();
            if (sum % partitions > 0)
            {
                return false;
            }

            return false;
        }
    }
}
