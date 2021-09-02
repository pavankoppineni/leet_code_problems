using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands/
    /// </summary>
    public class Leetcode_200_NumberOfIslands_V1
    {
        private int[][] directions = new int[4][];
        public Leetcode_200_NumberOfIslands_V1()
        {
            directions[0] = new int[] { 0, 1 };
            directions[1] = new int[] { 0, -1 };
            directions[2] = new int[] { 1, 0 };
            directions[3] = new int[] { -1, 0 };
        }

        public int FindNumberOfIslands(int[,] matrix)
        {
            var count = 0;
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            var visited = new bool[rows, columns];
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    if (visited[row, column])
                    {
                        continue;
                    }
                    var cell = matrix[row, column];
                    visited[row, column] = true;
                    if (cell == 0)
                    {
                        continue;
                    }
                    CountIslandArea(row, column, rows, columns, visited, matrix);
                    count += 1;
                }
            }
            return count;
        }

        private void CountIslandArea(int row, int column, int rows, int columns, bool[,] visited, int[,] matrix)
        {
            foreach (var direction in directions)
            {
                var currentRow = row + direction[0];
                var currentColumn = column + direction[1];
                if (currentRow >= rows || currentColumn >= columns || currentRow < 0 || currentColumn < 0)
                {
                    continue;
                }
                if (visited[currentRow, currentColumn])
                {
                    continue;
                }
                visited[currentRow, currentColumn] = true;
                if (matrix[currentRow, currentColumn] == 0)
                {
                    continue;
                }
                CountIslandArea(currentRow, currentColumn, rows, columns, visited, matrix);
            }
        }
    }
}
