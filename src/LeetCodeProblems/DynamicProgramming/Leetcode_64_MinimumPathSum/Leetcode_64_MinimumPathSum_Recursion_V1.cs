using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_64_MinimumPathSum
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-path-sum/
    /// </summary>
    public class Leetcode_64_MinimumPathSum_Recursion_V1
    {
        public int FindMinimumPathSum(int[][] maze)
        {
            return FindMinimumPathSum(maze, maze.Length - 1, maze[0].Length - 1);
        }

        private int FindMinimumPathSum(int[][] maze, int row, int column)
        {
            if (row == 0 && column == 0)
            {
                return maze[0][0];
            }

            var isValidTop = IsValid(maze, row - 1, column);
            var isValidLeft = IsValid(maze, row, column - 1);
            if (isValidTop && isValidLeft)
            {
                return maze[row][column] + Math.Min(FindMinimumPathSum(maze, row - 1, column), FindMinimumPathSum(maze, row, column - 1));
            }
            else if (isValidTop)
            {
                return maze[row][column] + FindMinimumPathSum(maze, row - 1, column);
            }
            return maze[row][column] + FindMinimumPathSum(maze, row, column - 1);
        }

        private bool IsValid(int[][] maze, int row, int column)
        {
            if (row < 0 || column < 0)
            {
                return false;
            }

            if (row >= maze.Length || column >= maze[0].Length)
            {
                return false;
            }

            return true;
        }
    }
}
