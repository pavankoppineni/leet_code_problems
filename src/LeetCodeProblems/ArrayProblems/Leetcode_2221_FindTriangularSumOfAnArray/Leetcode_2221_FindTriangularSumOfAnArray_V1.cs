using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2221_FindTriangularSumOfAnArray
{
    /// <summary>
    /// https://leetcode.com/problems/find-triangular-sum-of-an-array/
    /// </summary>
    public class Leetcode_2221_FindTriangularSumOfAnArray_V1
    {
        public int CalculateTriangularSum(int[] values)
        {
            var right = values.Length - 1;
            while (right > 0)
            {
                for (var index = 1; index <= right; index++)
                {
                    values[index - 1] = (values[index] + values[index - 1]) % 10;
                }
                right--;
            }
            return values[0];
        }
    }
}
