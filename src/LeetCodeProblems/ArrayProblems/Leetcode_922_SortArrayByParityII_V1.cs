using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sort-array-by-parity-ii/
    /// </summary>
    public class Leetcode_922_SortArrayByParityII_V1
    {
        public int[] SortyByParity(int[] values)
        {
            var newValues = new int[values.Length];
            var evenIndex = 0;
            var oddIndex = 1;
            for (var i = 0; i < values.Length; i++)
            {
                var val = values[i];
                var numberType = val & 1;

                //Case 1 : Value is odd
                if (numberType == 1)
                {
                    newValues[oddIndex] = val;
                    oddIndex += 2;
                }
                //Case 2 : Value is even
                else
                {
                    newValues[evenIndex] = val;
                    evenIndex += 2;
                }
            }
            return newValues;
        }
    }
}
