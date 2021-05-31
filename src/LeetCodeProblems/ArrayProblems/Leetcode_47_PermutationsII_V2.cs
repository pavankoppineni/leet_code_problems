using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations-ii/
    /// </summary>
    public class Leetcode_47_PermutationsII_V2
    {
        public IList<int[]> Permutations(int[] values)
        {
            var keys = new List<int>();
            var countArray = new List<int>();
            var permutations = new List<int[]>();
            var dict = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (dict.ContainsKey(value))
                {

                }
                else
                {
                    keys.Add(value);
                    countArray.Add(1);
                }
            }
            var result = new int[values.Length];
            //Permutations(dict.Keys, dict.Values,  result, 0, permutations);
            return permutations;
        }

        private void Permutations(IList<int> keys, IList<int> countArray, int[] permutationItem, int level, IList<int[]> result)
        {
            if (level == permutationItem.Length)
            {
                var permutationCopy = new int[permutationItem.Length];
                Array.Copy(permutationItem, permutationCopy, 0);
                result.Add(permutationCopy);
                return;
            }

            //for (var index = 0; index < keys.Length; index++)
            //{
            //    if (countArray[index] == 0)
            //    {
            //        continue;
            //    }

            //    permutationItem[level] = keys[index];
            //    countArray[index] -= 1;
            //    Permutations(keys, countArray, permutationItem, level + 1, result);
            //    countArray[index] += 1;
            //}
        }
    }
}
