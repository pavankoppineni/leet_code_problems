using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/letter-case-permutation/
    /// </summary>
    public class Leetcode_784_LetterCasePermutation_V1
    {
        private IList<string> _permutations;
        public IList<string> GeneratePermutations(string permutation)
        {
            _permutations = new List<string>();
            return _permutations;
        }

        private void GeneratePermutations(int index, char[] currentPermutation)
        {
            if (index >= currentPermutation.Length)
            {
                var permutation = new string(currentPermutation);
                _permutations.Add(permutation);
                return;
            }
        }
    }
}
