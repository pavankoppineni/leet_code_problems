using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subsequence-score/
    /// </summary>
    public class Leetcode_2542_MaximumSubsequenceScore_V1
    {
        public long CalculateMaximumScore(int[] nums1, int[] nums2, int k)
        {
            var maxScore = 0;
            var kSum = 0;
            var items = ConstructItems(nums1, nums2);
            var startIndex = 0;
            for (var index = 0; index < k; index++)
            {
                kSum += items[index].NumberOneValue;
            }
            maxScore = kSum * items[startIndex].NumberTwoValue;
            startIndex += 1;

            for (var index = k; index < nums1.Length; index++)
            {
                kSum += items[index].NumberOneValue;
                kSum -= items[startIndex].NumberOneValue;
                var currentScore = kSum * items[startIndex].NumberTwoValue;
                if (currentScore > maxScore)
                {
                    maxScore = currentScore;
                }
                startIndex += 1;
            }
            return maxScore;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        private Item[] ConstructItems(int[] nums1, int[] nums2)
        {
            var items = new Item[nums1.Length];
            for (var index = 0; index < nums1.Length; index++)
            {
                items[index] = new Item()
                {
                    NumberOneValue = nums1[index],
                    NumberTwoValue = nums2[index],
                };
            }
            Array.Sort(items, Item.Comparer);
            return items;
        }
    }

    public class Item : IComparer<Item>
    {
        public static Item Comparer = new Item();
        public int NumberOneValue { get; set; }
        public int NumberTwoValue { get; set; }

        public int Compare(Item x, Item y)
        {
            return x.NumberTwoValue.CompareTo(y.NumberTwoValue);
        }
    }
}
