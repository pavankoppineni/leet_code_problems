using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations-ii/
    /// </summary>
    public class Leetcode_47_PermutationsII_V1
    {
        private int[] values;
        private IList<IList<int>> permutations;
        private IDictionary<int, int> valueDict;
        public IList<IList<int>> GeneratePermutations(int[] values)
        {
            this.valueDict = new Dictionary<int, int>();
            this.values = values;
            this.permutations = new List<IList<int>>();
            foreach (var value in values)
            {
                if (valueDict.ContainsKey(value))
                {
                    this.valueDict[value] += 1;
                }
                else
                {
                    this.valueDict.Add(value, 1);
                }
            }
            return this.permutations;
        }

        private void GeneratePermutations(int index, int[] permutation)
        {
            if(index == values.Length)
            {
                permutations.Add(permutation.ToArray());
            }

            foreach (var item in valueDict)
            {
                if (item.Value == 0)
                {
                    continue;
                }
                valueDict[item.Key] -= 1;
                permutation[index] = item.Key;
                GeneratePermutations(index + 1, permutation);
                valueDict[item.Key] += 1;
            }
        }
    }
}
