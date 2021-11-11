using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems.GFG_SubsetSum
{
    /// <summary>
    /// https://www.geeksforgeeks.org/subset-sum-problem-dp-25/
    /// </summary>
    public class GFG_SubsetSum_V1
    {
        public bool FindSubsetSum(int[] values, int sum)
        {
            return FindSubsetSum(0, values, sum);
        }

        private bool FindSubsetSum(int level, int[] values, int sum)
        {
            if (sum < 0)
            {
                return false;
            }

            if (sum == 0)
            {
                return true;
            }

            if (level >= values.Length)
            {
                return false;
            }

            var inclusive = FindSubsetSum(level + 1, values, sum - values[level]);
            if (inclusive)
            {
                return true;
            }
            return FindSubsetSum(level + 1, values, sum);
        }
    }
}
