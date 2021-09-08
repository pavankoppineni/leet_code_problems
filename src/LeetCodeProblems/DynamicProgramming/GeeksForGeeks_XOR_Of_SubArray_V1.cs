using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://www.geeksforgeeks.org/xor-of-a-subarray-range-of-elements/
    /// </summary>
    public class GeeksForGeeks_XOR_Of_SubArray_V1
    {
        private int[] _values;
        private int[,] _matrix;
        public void AddArray(int[] values)
        {
            _matrix = GenerateXORMatrix(values);
            _values = values;
        }

        private int[,] GenerateXORMatrix(int[] values)
        {
            var matrix = new int[values.Length, 32];
            for (var i = 0; i < values.Length; i++)
            {
                var value = values[i];
                for (var j = 0; j < 32; j++)
                {
                    var bit = value & 1 << j;
                    if (bit != 0)
                    {
                        if (i == 0)
                        {
                            matrix[i, j] += 1;
                        }
                        else
                        {
                            if (i == 0) { continue; }
                            matrix[i, j] = matrix[i - 1, j] + 1;
                        }
                    }
                    else
                    {
                        if (i == 0) { continue; }
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
            }
            return matrix;
        }

        public int CalculateXOR(int left, int right)
        {
            var result = 0;
            for (var i = 0; i < 32; i++)
            {
                var upperBound = _matrix[right, i];
                var lowerBound = _matrix[left - 1, i];
                var diff = upperBound - lowerBound;
                if ((diff & 1) == 1)
                {
                    result = result | 1 << i;
                }
            }
            return result;
        }
    }
}
