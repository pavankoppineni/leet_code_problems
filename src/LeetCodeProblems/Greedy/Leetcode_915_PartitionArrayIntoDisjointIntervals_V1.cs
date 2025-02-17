using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/partition-array-into-disjoint-intervals
    /// </summary>
    public class Leetcode_915_PartitionArrayIntoDisjointIntervals_V1
    {
        public int CalculateDisjointInterval(int[] values)
        {
            var pairs = new MaxMinPairBuilder()
                .Values(values)
                .Build();
            for (var index = 0; index < pairs.Length - 1; index++)
            {
                var currentPair = pairs[index];
                var nextPair = pairs[index + 1];
                if (currentPair.Max < nextPair.Min)
                {
                    return index + 1;
                }
            }
            return 0;
        }
    }

    public class MaxMinPairBuilder
    {
        private int[] _values;
        private MaxMinPair[] _pairs;
        public MaxMinPairBuilder Values(int[] values)
        {
            _values = values;
            _pairs = new MaxMinPair[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                _pairs[index] = new MaxMinPair();
            }
            return this;
        }

        public MaxMinPair[] Build()
        {
            BuildMax();
            BuildMin();
            return _pairs;
        }

        private void BuildMax()
        {
            var prev = _pairs[0];
            prev.Max = _values[0];
            for (var index = 1; index < _pairs.Length; index++)
            {
                var max = Math.Max(prev.Max, _values[index]);
                _pairs[index].Max = max;
                prev = _pairs[index];
            }
        }

        private void BuildMin()
        {
            var lastIndex = _values.Length - 1;
            var prev = _pairs[lastIndex];
            prev.Min = _values[lastIndex];
            for (var index = lastIndex - 1; index >= 0; index--)
            {
                var min = Math.Min(prev.Min, _values[index]);
                _pairs[index].Min = min;
                prev = _pairs[index];
            }
        }

        public class MaxMinPair
        {
            public int Max { get; set; }
            public int Min { get; set; }
        }
    }
}
