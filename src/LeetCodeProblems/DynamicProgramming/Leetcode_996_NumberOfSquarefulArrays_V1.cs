using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-squareful-arrays
    /// </summary>
    public class Leetcode_996_NumberOfSquarefulArrays_V1
    {
        private int[] _values;
        private HashSet<long> _squaresLookup;
        public int CalculateNumberOfSquarefulArrays(int[] values)
        {
            var maxValues = CalculateMaxValues(values);
            _squaresLookup = GenerateSquaresLookup(maxValues.max + maxValues.secondMax);
            return CalculateNumberOfSquarefulArrays(0);
        }

        private int CalculateNumberOfSquarefulArrays(int index)
        {
            if (index >= _values.Length)
            {
                return IsSquarefulArray(_values) ? 1 : 0;
            }
            var count = 0;
            for (var currentIndex = index; currentIndex < _values.Length; currentIndex++)
            {
                Swap(index, currentIndex);
                count += CalculateNumberOfSquarefulArrays(currentIndex);
                Swap(index, currentIndex);
            }
            return count;
        }

        private void Swap(int fromIndex, int toIndex)
        {
            var temp = _values[fromIndex];
            _values[fromIndex] = _values[toIndex];
            _values[toIndex] = temp;
        }

        private bool IsSquarefulArray(int[] values)
        {
            for (var index = 1; index < values.Length; index++)
            {
                if (!_squaresLookup.Contains(values[index] + values[index - 1]))
                {
                    return false;
                }
            }
            return true;
        }

        private HashSet<long> GenerateSquaresLookup(int maxValue)
        {
            var squaresLookup = new HashSet<long>();
            for (var number = 1; number * number <= maxValue; number++)
            {
                squaresLookup.Add(number * number);
            }
            return squaresLookup;
        }

        private (int max, int secondMax) CalculateMaxValues(int[] values)
        {
            var max = values[0];
            var secondMax = values[0];
            for (var i = 1; i < values.Length; i++)
            {
                //When : Current value is greater than max value
                if (values[i] > max)
                {
                    secondMax = max;
                    max = values[i];
                    continue;
                }

                //When : Current value is greater than second max value
                if (values[i] > secondMax)
                {
                    secondMax = values[i];
                }
            }
            return (max, secondMax);
        }
    }
}
