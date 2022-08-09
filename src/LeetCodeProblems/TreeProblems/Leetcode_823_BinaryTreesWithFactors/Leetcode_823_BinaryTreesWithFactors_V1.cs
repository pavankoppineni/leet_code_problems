using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_823_BinaryTreesWithFactors
{
    /// <summary>
    /// https://leetcode.com/problems/binary-trees-with-factors/
    /// </summary>
    public class Leetcode_823_BinaryTreesWithFactors_V1
    {
        private int[] _values;
        private IDictionary<int, long> _factorsLookup;
        public int CalculateBinaryTrees(int[] values)
        {
            _factorsLookup = new Dictionary<int, long>();
            Array.Sort(values);
            _values = values;
            _factorsLookup.Add(values[0], 1);
            for (var index = 1; index < values.Length; index++)
            {
                var factorsCount = CalculateFactors(index);
                _factorsLookup.Add(_values[index], factorsCount);
            }
            var numerator = _factorsLookup.Values.Sum();
            var denominator = Math.Pow(10, 9) + 7;
            return (int)(numerator % denominator);
        }

        private long CalculateFactors(int index)
        {
            var value = _values[index];
            var midValue = value / 2;
            long count = 1;
            var currentIndex = 0;
            while (currentIndex < index)
            {
                if (_values[currentIndex] >> 1 > midValue)
                {
                    break;
                }
                if (value % _values[currentIndex] == 0)
                {
                    var quotient = _values[index] / _values[currentIndex];
                    if (_factorsLookup.ContainsKey(quotient))
                    {
                        var quotientFactors = _factorsLookup[quotient];
                        var denominatorFactors = _factorsLookup[_values[currentIndex]];
                        count += quotientFactors * denominatorFactors;
                    }
                }
                currentIndex++;
            }
            return count;
        }
    }
}
