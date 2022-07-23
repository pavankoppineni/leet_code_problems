using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_1712_WaysToSplitArrayIntoThreeSubarrays
{
    /// <summary>
    /// https://leetcode.com/problems/ways-to-split-array-into-three-subarrays/
    /// </summary>
    public class Leetcode_1712_WaysToSplitArrayIntoThreeSubarrays_V1
    {
        private int[] _values;
        private int[] _prefixSum;
        public int CalculateNumberOfWays(int[] values)
        {
            if (values.Length == 3)
            {
                if (values[0] <= values[1] && values[1] <= values[2])
                {
                    return 1;
                }
                return 0;
            }

            long numberOfWays = 0;
            _prefixSum = new int[values.Length];
            _values = values;
            var totalSum = 0;
            for (var index = 0; index < _prefixSum.Length; index++)
            {
                totalSum += _values[index];
                _prefixSum[index] = totalSum;
            }

            for (var index = 1; index < _prefixSum.Length - 2; index++)
            {
                var currentNumberOfWays = CalculateNumberOfWays(index);
                if (currentNumberOfWays == 0)
                {
                    break;
                }
                numberOfWays += currentNumberOfWays;
            }

            if (_prefixSum[_values.Length - 3] <= _values[_values.Length - 2] && _values[_values.Length - 2] <= _values[_values.Length - 1])
            {
                numberOfWays += 1;
            }
            return (int)(numberOfWays % 1000000007);
        }

        private int CalculateNumberOfWays(int index)
        {
            var offset = _prefixSum[index - 1];
            var endIndex = FindEndIndex(offset, index, _prefixSum.Length - 2, -1);
            var startIndex = FindStartIndex(offset, index, _prefixSum.Length - 2, -1);
            if (startIndex == -1 || endIndex == -1 || startIndex > endIndex)
            {
                return 0;
            }
            return endIndex - startIndex + 1;
        }

        private int FindEndIndex(int offset, int start, int end, int index)
        {
            if (start > end)
            {
                return index;
            }
            var mid = start + (end - start) / 2;
            var leftArraySum = _prefixSum[mid] - offset;
            var rightArraySum = _prefixSum[_prefixSum.Length - 1] - _prefixSum[mid];
            if (leftArraySum <= rightArraySum)
            {
                return FindEndIndex(offset, mid + 1, end, mid);
            }
            return FindEndIndex(offset, start, mid - 1, index);
        }

        private int FindStartIndex(int leftArraySum, int start, int end, int index)
        {
            if (start > end)
            {
                return index;
            }
            var mid = start + (end - start) / 2;
            var rightArraySum = _prefixSum[mid] - leftArraySum;

            //Case One : When right array sum is greater than left array sum
            if (rightArraySum >= leftArraySum)
            {
                return FindStartIndex(leftArraySum, start, mid - 1, mid);
            }
            return FindStartIndex(leftArraySum, mid + 1, end, index);
        }
    }
}
