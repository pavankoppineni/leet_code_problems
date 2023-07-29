using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/additive-number/
    /// </summary>
    public class Leetcode_306_AdditiveNumber_V1
    {
        private char[] _nums;
        private IDictionary<(int start, int end), int> _partitionsLookup;
        public bool IsAdditiveNumber(string num)
        {
            _partitionsLookup = new Dictionary<(int start, int end), int>();
            _nums = num.ToCharArray();
            var stack = new Stack<(int start, int end)>();
            return IsAdditiveNumber(0, stack);
        }

        private int[] ConstructNumbersArray(Stack<(int stack, int end)> stack)
        {
            var partitions = stack.ToArray();
            var numberPartitions = new int[partitions.Length];
            for (int paritionIndex = partitions.Length - 1, offset = 0; paritionIndex >= 0; paritionIndex--, offset++)
            {
                numberPartitions[offset] = ConvertPartitionToNumber(partitions[paritionIndex]);
            }
            return numberPartitions;
        }

        private int ConvertPartitionToNumber((int start, int end) partition)
        {
            if(_partitionsLookup.ContainsKey(partition))
            {
                return _partitionsLookup[partition];
            }
            if (partition.start == partition.end)
            {
                return _nums[partition.start] - '0';
            }
            if (_nums[partition.start] == '0')
            {
                return 0;
            }

            var partitionNumber = 0;
            for (var index = partition.start; index <= partition.end; index++)
            {
                partitionNumber = partitionNumber * 10 + (_nums[index] - '0');
            }
            _partitionsLookup.Add(partition, partitionNumber);
            return partitionNumber;
        }

        private bool IsAdditiveNumber(int index, Stack<(int stack, int end)> stack)
        {
            if (index >= _nums.Length)
            {
                if (stack.Count < 3)
                {
                    return false;
                }

                var numberPartitions = ConstructNumbersArray(stack);
                for (var paritionIndex = 2; paritionIndex < numberPartitions.Length; paritionIndex++)
                {
                    if (numberPartitions[paritionIndex] != numberPartitions[paritionIndex - 1] + numberPartitions[paritionIndex - 2])
                    {
                        return false;
                    }
                }
                return true;
            }

            var result = false;
            if (_nums[index] == '0')
            {
                stack.Push((index, index));
                result = IsAdditiveNumber(index + 1, stack);
                if (result)
                {
                    return true;
                }
                stack.Pop();
                return false;
            }

            for (var currentIndex = index; currentIndex < _nums.Length; currentIndex++)
            {
                stack.Push((index, currentIndex));
                result = IsAdditiveNumber(currentIndex + 1, stack);
                if (result)
                {
                    break;
                }
                stack.Pop();
            }
            return result;
        }
    }
}
