using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations-ii/
    /// </summary>
    public class Leetcode_47_PermutationsII_V1
    {
        private int length;
        private int[] keysArray;
        private int[] valuesArray;
        private IList<IList<int>> permutations;
        private int[] permutationItem;

        public IList<IList<int>> Permutate(int[] nums)
        {
            permutations = new List<IList<int>>();
            length = nums.Length;
            var numDictionary = new Dictionary<int, int>();
            permutationItem = new int[nums.Length];
            foreach (var num in nums)
            {
                if (numDictionary.ContainsKey(num))
                {
                    numDictionary[num] += 1;
                }
                else
                {
                    numDictionary.Add(num, 1);
                }
            }
            keysArray = numDictionary.Keys.ToArray();
            valuesArray = numDictionary.Values.ToArray();
            Permutate(0);
            return permutations;
        }

        private void Permutate(int rank)
        {
            if (rank == length)
            {
                var currentPermutationItem = new int[length];
                Array.Copy(permutationItem, 0, currentPermutationItem, 0, length);
                permutations.Add(currentPermutationItem);
                return;
            }

            for (var i = 0; i < keysArray.Length; i++)
            {
                if (valuesArray[i] == 0)
                {
                    continue;
                }
                valuesArray[i] -= 1;
                permutationItem[rank] = keysArray[i];
                Permutate(rank + 1);
                valuesArray[i] += 1;
            }
        }
    }
}
