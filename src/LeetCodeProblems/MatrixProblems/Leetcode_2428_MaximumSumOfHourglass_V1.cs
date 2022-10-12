using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-of-an-hourglass/
    /// </summary>
    public class Leetcode_2428_MaximumSumOfHourglass_V1
    {
        public int CalculateMaximumSum(int[][] grid)
        {
            var prefixSum = CalculatePrefixSum(grid);
            return CalculateMaximumHourGlass(grid, prefixSum);
        }

        private int CalculateMaximumHourGlass(int[][] grid, int[][] prefixSum)
        {
            var maximumSum = 0;
            for (var row = 2; row < grid.Length; row++)
            {
                for (var col = 2; col < grid[row].Length; col++)
                {
                    var deductions = 0;
                    if (col > 2 && row > 2)
                    {
                        deductions = prefixSum[row][col - 3] + prefixSum[row - 3][col];
                        deductions -= prefixSum[row - 3][col - 3];
                    }
                    else if (col > 2)
                    {
                        deductions = prefixSum[row][col - 3];
                    }
                    else if (row > 2)
                    {
                        deductions = prefixSum[row - 3][col];
                    }
                    var currentSum = prefixSum[row][col] - grid[row - 1][col] - grid[row - 1][col - 2] - deductions;
                    if (currentSum > maximumSum)
                    {
                        maximumSum = currentSum;
                    }
                }
            }
            return maximumSum;
        }

        private int[][] CalculatePrefixSum(int[][] grid)
        {
            var prefixSum = new int[grid.Length][];
            for (var row = 0; row < grid.Length; row++)
            {
                prefixSum[row] = new int[grid[row].Length];
                for (var col = 0; col < grid[row].Length; col++)
                {
                    if (row > 0 && col > 0)
                    {
                        prefixSum[row][col] -= prefixSum[row - 1][col - 1];
                        prefixSum[row][col] += prefixSum[row][col - 1] + prefixSum[row - 1][col];
                    }
                    else if (col > 0)
                    {
                        prefixSum[row][col] += prefixSum[row][col - 1];
                    }
                    else if (row > 0)
                    {
                        prefixSum[row][col] += prefixSum[row - 1][col];
                    }
                    prefixSum[row][col] += grid[row][col];
                }
            }
            return prefixSum;
        }
    }
}
