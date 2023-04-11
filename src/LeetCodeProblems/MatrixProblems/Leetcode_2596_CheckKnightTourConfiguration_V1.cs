using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/check-knight-tour-configuration/
    /// </summary>
    public class Leetcode_2596_CheckKnightTourConfiguration_V1
    {
        public bool ValidateKnightTourConfiguration(int[][] grid)
        {
            var currentStep = 0;
            var maximumSteps = grid.Length * grid.Length - 1;
            while (currentStep < maximumSteps)
            {

            }
            return false;
        }

        private IDictionary<int, (int row, int column)> CreateSteps(int[][] grid)
        {
            var steps = new Dictionary<int, (int row, int column)>();
            for (var row = 0; row < grid.Length; row++)
            {
                for (var column = 0; column < grid[row].Length; column++)
                {
                    var index = grid[row][column];
                    steps.Add(index, (row, column));
                }
            }
            return steps;
        }
    }
}
