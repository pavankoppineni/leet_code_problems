using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.GFG_SubsetSum
{
    /// <summary>
    /// https://www.geeksforgeeks.org/subset-sum-problem-dp-25/
    /// </summary>
    public class GFG_SubsetSum_V1
    {
        public bool FindSubsetSum(int[] values, int sum)
        {
            var matrix = new bool[values.Length + 1, sum + 1];
            matrix[0, 0] = true;
            for(var index = 1; index <= values.Length; index++)
            {
                matrix[index, 0] = true;
            }

            for(var row = 1; row <= values.Length; row++)
            {
                for(var column = 1; column <= sum; column++)
                {
                    var value = values[row - 1];
                    matrix[row, column] = matrix[row - 1, column];
                    if(value > column)
                    {
                        continue;
                    }
                    var remainingSum = column - value;
                    matrix[row, column] = matrix[row, column] || matrix[row - 1, remainingSum];
                }
            }

            return false;
        }
    }
}
