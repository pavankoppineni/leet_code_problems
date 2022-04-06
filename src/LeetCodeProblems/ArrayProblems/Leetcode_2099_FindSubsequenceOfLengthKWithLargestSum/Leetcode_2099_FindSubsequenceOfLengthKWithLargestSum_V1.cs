using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2099_FindSubsequenceOfLengthKWithLargestSum
{
    /// <summary>
    /// https://leetcode.com/problems/find-subsequence-of-length-k-with-the-largest-sum/
    /// </summary>
    public class Leetcode_2099_FindSubsequenceOfLengthKWithLargestSum_V1
    {
        public int[] MaxSubsequence(int[] nums, int k)
        {
            var result = new int[k];
            var items = new List<ArrayItem>(nums.Length);
            for (var index = 0; index < nums.Length; index++)
            {
                items.Add(new ArrayItem(index, nums[index]));
            }
            items.Sort();
            var sortedIndexList = new SortedSet<int>();
            var lastIndex = nums.Length - 1;
            while (k > 0)
            {
                sortedIndexList.Add(items[lastIndex].Index);
                k--;
                lastIndex--;
            }
            var currentIndex = 0;
            foreach (var sortedItem in sortedIndexList)
            {
                result[currentIndex] = nums[sortedItem];
                currentIndex++;
            }
            return result;
        }
    }

    public class ArrayItem : IComparable<ArrayItem>
    {
        public ArrayItem(int index, int value)
        {
            Index = index;
            Value = value;
        }

        public int Value { get; set; }
        public int Index { get; set; }
        public int CompareTo(ArrayItem other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
