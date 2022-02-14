using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_416_PartitionEqualSubsetSum
{
    /// <summary>
    /// https://leetcode.com/problems/partition-equal-subset-sum/
    /// </summary>
    public class Leetcode_416_PartitionEqualSubsetSum_V1
    {
        public bool CanPartition(int[] values)
        {
            Array.Sort(values);
            var sum = values.Sum();
            if ((sum & 1) == 1)
            {
                return false;
            }
            var target = sum >> 1;
            var matrix = new bool[values.Length + 1, target + 1];
            matrix[0, 0] = true;
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, 0] = true;
            }
            for (var col = 1; col < matrix.GetLength(1); col++)
            {
                matrix[0, col] = false;
            }
            for (var row = 1; row < matrix.GetLength(0); row++)
            {
                var value = values[row - 1];
                for (var col = 1; col < matrix.GetLength(1); col++)
                {
                    //Case 1 : Value is greater than col
                    //Action : Exclude current row
                    if (value > col)
                    {
                        matrix[row, col] = matrix[row - 1, col];
                    }
                    //Case 2 : Value is less than col
                    //Action : Get best of two options
                    //1. Exclude current row
                    //2. Include current row
                    else
                    {
                        var diff = col - value;
                        matrix[row, col] = matrix[row - 1, diff] || matrix[row - 1, col];
                    }
                }
            }
            return matrix[values.Length, target];
        }
    }
}
