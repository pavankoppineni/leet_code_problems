using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sum-in-a-matrix/description
    /// </summary>
    public class Leetcode_2679_SumInMatrix_V1
    {
        public int CalculateSum(int[][] nums)
        {
            var colCount = nums[0].Length;
            var resultArray = new int[colCount];
            for (var index = 0; index < colCount; index++)
            {
                resultArray[index] = -1;
            }

            for (var row = 0; row < nums.Length; row++)
            {
                Array.Sort(nums[row]);
                for (var col = 0; col < colCount; col++)
                {
                    if (resultArray[col] < nums[row][col])
                    {
                        resultArray[col] = nums[row][col];
                    }
                }
            }

            return resultArray.Sum();
        }
    }
}
