using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    public class Leetcode_46_Permutations_V2
    {
        public IList<int[]> GeneratePermutations(int[] values)
        {
            var permutationGenerator = new PermutationGenerator(values);
            return permutationGenerator.Generate();
        }

        public class PermutationGenerator
        {
            private readonly int[] values;
            private readonly int leafLevel;
            private readonly IList<int[]> permutations;
            public PermutationGenerator(int[] values)
            {
                this.values = values;
                this.leafLevel = values.Length;
                this.permutations = new List<int[]>();
            }

            public IList<int[]> Generate()
            {
                Generate(0, 0);
                return this.permutations;
            }

            private void Generate(int level, int currentIndex)
            {
                if (level == leafLevel)
                {
                    var newArray = new int[values.Length];
                    Array.Copy(values, newArray, values.Length);
                    this.permutations.Add(newArray);
                    return;
                }
                for (var index = currentIndex; index < values.Length; index++)
                {
                    Swap(index, currentIndex);
                    Generate(level + 1, currentIndex + 1);
                    Swap(index, currentIndex);
                }
            }

            private void Swap(int i, int j)
            {
                var temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }
    }
}
