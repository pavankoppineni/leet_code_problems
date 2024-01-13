using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/sorting-three-groups/
    /// </summary>
    public class Leetcode_2826_SortingThreeGroups_V1
    {
        public int CalculateMinimumOperations(IList<int> nums)
        {
            var operations = new Operations();
            foreach (var num in nums)
            {
                operations = CalculateOperations(num, operations);
            }
            return operations.MinThree;
        }

        private Operations CalculateOperations(int num, Operations operations)
        {
            var groupOne = 0;
            var groupTwo = 0;
            var groupThree = 0;
            switch (num)
            {
                case 1:
                    groupOne = operations.GroupOne;
                    groupTwo = operations.MinTwo + 1;
                    groupThree = operations.MinThree + 1;
                    break;
                case 2:
                    groupOne = operations.GroupOne + 1;
                    groupTwo = operations.MinTwo;
                    groupThree = operations.MinThree + 1;
                    break;
                case 3:
                    groupOne = operations.GroupOne + 1;
                    groupTwo = operations.MinTwo + 1;
                    groupThree = operations.MinThree;
                    break;
            }
            operations.Update(groupOne, groupTwo, groupThree);
            return operations;
        }

        internal class Operations
        {
            internal int GroupOne { get; set; }
            internal int GroupTwo { get; set; }
            internal int GroupThree { get; set; }
            internal int MinTwo { get; set; }
            internal int MinThree { get; set; }
            internal void Update(int groupOne, int groupTwo, int groupThree)
            {
                GroupOne = groupOne;
                GroupTwo = groupTwo;
                GroupThree = groupThree;
                MinTwo = Math.Min(GroupOne, GroupTwo);
                MinThree = Math.Min(GroupThree, MinTwo);
            }
        }
    }
}
