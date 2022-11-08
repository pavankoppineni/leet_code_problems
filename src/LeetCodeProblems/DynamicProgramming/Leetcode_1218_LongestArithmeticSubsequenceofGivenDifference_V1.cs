using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/longest-arithmetic-subsequence-of-given-difference/
    /// </summary>
    public class Leetcode_1218_LongestArithmeticSubsequenceofGivenDifference_V1
    {
        private int[] _values;
        private int _count;
        private int _difference;
        private IDictionary<int, int> _arithmeticSequenceMemory;
        private IDictionary<int, IList<int>> _valuesLookup;
        public int CalculateLongestAirthmeticSequence(int[] values, int difference)
        {
            _arithmeticSequenceMemory = new Dictionary<int, int>();
            _valuesLookup = CreateValuesLookup(values);
            _difference = difference;
            _values = values;
            _count = values.Length;
            var currentMaxLength = 0;

            for (var index = 0; index < _count; index++)
            {
                currentMaxLength = Math.Max(CalculateLongestArithmeticSequence(index), currentMaxLength);
            }
            return currentMaxLength + 1;
        }

        /// <summary>
        /// Creates values look up, key being value of an array and
        /// value being indexes of key present in values array.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static IDictionary<int, IList<int>> CreateValuesLookup(int[] values)
        {
            var lookup = new Dictionary<int, IList<int>>();
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                if (lookup.ContainsKey(value))
                {
                    lookup[value].Add(index);
                }
                else
                {
                    lookup.Add(value, new List<int>() { index });
                }
            }
            return lookup;
        }

        /// <summary>
        /// Calculates maximum length of arithmetic sequence from given index
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <returns></returns>
        private int CalculateLongestArithmeticSequence(int currentIndex)
        {
            if (currentIndex >= _count)
            {
                return 0;
            }

            /*
             * When : Arithmetic sequence is already calculated for given index
             * Then : Return calculated arithmetic sequence from memory
             */
            if (_arithmeticSequenceMemory.ContainsKey(currentIndex))
            {
                return _arithmeticSequenceMemory[currentIndex];
            }

            var maximumLengthSequence = 0;
            var value = _values[currentIndex];
            var nextValue = value + _difference;
            if (_valuesLookup.ContainsKey(nextValue))
            {
                foreach (var nextValueIndex in _valuesLookup[nextValue])
                {
                    /*
                     * When : currentIndex is greater than nextValueIndex
                     * Then : Do nothing
                     */
                    if (nextValueIndex <= currentIndex)
                    {
                        continue;
                    }

                    /*
                     * When : currentIndex is less than nextValueIndex
                     * Then : Calculate arithmetic sequence from nextValueIndex
                     */
                    var currentMaxLength = CalculateLongestArithmeticSequence(nextValueIndex) + 1;
                    maximumLengthSequence = Math.Max(maximumLengthSequence, currentMaxLength);
                }
            }

            /*
             * When : currentIndex is not part of _arithmeticSequenceMemory
             * Then : Add calculated length of arithmetic sequence to _arithmeticSequenceMemory
             */
            _arithmeticSequenceMemory.Add(currentIndex, maximumLengthSequence);
            return maximumLengthSequence;
        }
    }
}
