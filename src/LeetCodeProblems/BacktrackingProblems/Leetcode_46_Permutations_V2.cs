using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    public class Leetcode_46_Permutations_V2
    {
        private int[] _values;
        public IList<int[]> GeneratePermutatons(int[] values)
        {
            _values = values;
            var permutations = new List<int[]>();
            return permutations;
        }

        private void GeneratePermutations(int index, int permutation)
        {
        }
    }
}
