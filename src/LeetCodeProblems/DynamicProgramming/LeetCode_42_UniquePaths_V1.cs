using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths/
    /// </summary>
    public class LeetCode_42_UniquePaths_V1
    {
        private int[,] paths;
        public int FindNumberOfUniquePaths(int rows, int columns)
        {
            paths = new int[rows, columns];
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    paths[row, column] = -1;
                }
            }
            paths[0, 0] = 1;
            paths[rows - 1, columns - 1] = FindUniquePaths(rows - 1, columns - 1);
            return paths[rows - 1, columns - 1];
        }

        private int FindUniquePaths(int rows, int columns)
        {
            if (rows < 0 || columns < 0)
            {
                return 0;
            }

            if (paths[rows, columns] != -1)
            {
                return paths[rows, columns];
            }

            paths[rows, columns] = FindUniquePaths(rows - 1, columns) + FindUniquePaths(rows, columns - 1);
            return paths[rows, columns];
        }
    }
}
