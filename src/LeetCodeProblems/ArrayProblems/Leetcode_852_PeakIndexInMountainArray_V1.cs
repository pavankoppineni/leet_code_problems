using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/peak-index-in-a-mountain-array/
    /// </summary>
    public class Leetcode_852_PeakIndexInMountainArray_V1
    {
        private int[] _values;
        public int CalculateIndex(int[] values)
        {
            _values = values;
            return CalculateIndex(0, values.Length - 1);
        }

        private int CalculateIndex(int start, int end)
        {
            var diff = end - start;
            if (diff == 1)
            {
                return _values[start] > _values[end] ? start : end;
            }
            if (start == end)
            {
                return start;
            }

            var mid = start + (diff >> 1);
            if (_values[mid] > _values[mid - 1])
            {
                return CalculateIndex(mid, end);
            }
            return CalculateIndex(start, mid);
        }
    }
}
