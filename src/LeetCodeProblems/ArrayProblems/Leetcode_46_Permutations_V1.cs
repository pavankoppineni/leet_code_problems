using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    public class Leetcode_46_Permutations_V1
    {
        private IList<IList<int>> permutations;
        private int[] nums;

        public IList<IList<int>> Permutate(int[] nums)
        {
            this.nums = nums;
            permutations = new List<IList<int>>();
            Permutate(0);
            return permutations;
        }

        private void Permutate(int index)
        {
            if (nums.Length == index)
            {
                var permutationItem = new List<int>();
                foreach (var num in nums)
                {
                    permutationItem.Add(num);
                }
                permutations.Add(permutationItem);
                return;
            }

            for (var i = index; i < nums.Length; i++)
            {
                Swap(i, index);
                Permutate(index + 1);
                Swap(i, index);
            }
        }

        private void Swap(int indexA, int indexB)
        {
            var temp = nums[indexA];
            nums[indexA] = nums[indexB];
            nums[indexB] = temp;
        }
    }
}
