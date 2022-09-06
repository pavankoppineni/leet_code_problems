using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_801_MinimumSwapsToMakeSequencesIncreasing
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-swaps-to-make-sequences-increasing/
    /// </summary>
    public class Leetcode_801_MinimumSwapsToMakeSequencesIncreasing_V1
    {
        private int[] _nums1;
        private int[] _nums2;
        private IDictionary<int, (bool, int)> _lookup;
        public int CalculateMinimumSwaps(int[] nums1, int[] nums2)
        {
            _lookup = new Dictionary<int, (bool, int)>();
            _nums1 = nums1;
            _nums2 = nums2;
            return CalculateMinimumSwaps(nums1.Length - 1).Item2;
        }

        private (bool, int) CalculateMinimumSwaps(int index)
        {
            if (_lookup.ContainsKey(index))
            {
                return _lookup[index];
            }

            if (index < 0)
            {
                for (index = 1; index < _nums1.Length; index++)
                {
                    if (_nums1[index] <= _nums1[index - 1])
                    {
                        return (false, 0);
                    }

                    if (_nums2[index] <= _nums2[index - 1])
                    {
                        return (false, 0);
                    }
                }

                return (true, 0);
            }

            (bool, int) minSwaps;
            if (_nums1[index] == _nums2[index])
            {
                minSwaps = CalculateMinimumSwaps(index - 1);
            }
            else
            {
                var noSwap = CalculateMinimumSwaps(index - 1);
                Swap(index);
                var swap = CalculateMinimumSwaps(index - 1);
                swap.Item2 += 1;
                Swap(index);
                if (noSwap.Item1 && swap.Item1)
                {
                    minSwaps = (true, Math.Min(noSwap.Item2, swap.Item2));
                }
                else if (noSwap.Item1)
                {
                    minSwaps = noSwap;
                }
                else
                {
                    minSwaps = swap;
                }
            }
            if (minSwaps.Item1)
            {
                _lookup.Add(index, minSwaps);
            }
            return minSwaps;
        }

        private void Swap(int index)
        {
            var temp = _nums1[index];
            _nums1[index] = _nums2[index];
            _nums2[index] = temp;
        }
    }
}
