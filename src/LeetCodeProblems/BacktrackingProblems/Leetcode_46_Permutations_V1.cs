using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    public class Leetcode_46_Permutations_V1
    {
        private IList<IList<int>> permutations;
        public IList<IList<int>> GeneratePermutations(int[] values)
        {
            permutations = new List<IList<int>>();
            GeneratePermutations(0, values);
            return permutations;
        }

        private void GeneratePermutations(int index, int[] permutation)
        {
            if (index == permutation.Length)
            {
                permutations.Add(permutation.ToArray());
                return;
            }
            for (var currentIndex = index; currentIndex < permutation.Length; currentIndex++)
            {
                Swap(currentIndex, index, permutation);
                GeneratePermutations(index + 1, permutation);
                Swap(currentIndex, index, permutation);
            }
        }

        private void Swap(int sourceIndex, int destinationIndex, int[] permutation)
        {
            var temp = permutation[sourceIndex];
            permutation[sourceIndex] = permutation[destinationIndex];
            permutation[destinationIndex] = temp;
        }
    }
}
