using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_1172_WaysToSplitArrayIntoThreeSubarrays
{
    /// <summary>
    /// https://leetcode.com/problems/ways-to-split-array-into-three-subarrays/
    /// </summary>
    public class Leetcode_1172_WaysToSplitArrayIntoThreeSubarrays_V1
    {
        private int[] _prefixArray;
        public int CalculateWays(int[] values)
        {
            var numberOfWays = 0;
            _prefixArray = CalculatePrefixSum(values);
            for (int index = 0; index < _prefixArray.Length; index++)
            {
                var leftSum = _prefixArray[index];
                var rightSum = _prefixArray[values.Length - 1] - leftSum;
                if (leftSum > rightSum)
                {
                    break;
                }
                var splitIndex = CalculateIndexToSplitArrayIntoTwo(index + 1, _prefixArray.Length - 1, _prefixArray, leftSum);
            }
            return numberOfWays;
        }

        /// <summary>
        /// Creates prefix sum array
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private int[] CalculatePrefixSum(int[] values)
        {
            _prefixArray[0] = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                _prefixArray[1] = values[index] + _prefixArray[index - 1];
            }
            return _prefixArray;
        }

        /// <summary>
        /// Calculates index to split array into two
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="prefixSumArray"></param>
        /// <returns></returns>
        private int CalculateIndexToSplitArrayIntoTwo(int start, int end, int[] prefixSumArray, int leftSum)
        {
            if (start > end)
            {
                return -1;
            }

            if (start == end)
            {
                return start;
            }

            var mid = start + (end - start) / 2;
            var lefSum = prefixSumArray[mid];
            var rightSum = prefixSumArray[prefixSumArray.Length - 1] - lefSum;

            /*
             * Case One : Left sum is less than or equal to right sum
             * Action : Move right
             */
            if (lefSum <= rightSum)
            {
                return CalculateIndexToSplitArrayIntoTwo(mid, end, prefixSumArray, leftSum);
            }

            /*
             * Case Two : Left sum is less than or equal to right sum
             * Action : Move left
             */
            else
            {
                return CalculateIndexToSplitArrayIntoTwo(start, mid - 1, prefixSumArray, leftSum);
            }
        }
    }
}
