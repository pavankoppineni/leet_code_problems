using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_100_NumberOfIslands
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands/
    /// </summary>
    public class Leetcode_200_NumberOfIslands_V2
    {
        private readonly int[][] _directions;
        private bool[,] _visited;
        public Leetcode_200_NumberOfIslands_V2()
        {
            _directions = new int[4][]
            {
                new int[] { 0, 1 },
                new int[] { 0, -1 },    
                new int[] {-1, 0 },
                new int[] {1, 0 }
            };
        }

        public int FindNumberOfIslands(int[][] matrix)
        {
            var islandsCount = 0;
            _visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            var rowsCount = matrix.Length;
            var colsCount = matrix[0].Length;
            for (var row = 0; row < rowsCount; row++)
            {
                for (var col = 0; col < colsCount; col++)
                {
                    var cell = matrix[row][col];

                    //Case 1 : When cell is visited
                    if (_visited[row, col])
                    {
                        continue;
                    }

                    _visited[row, col] = true;
                    //Case 2 : When cell is 0
                    if (cell == 0)
                    {
                        continue;
                    }
                    CheckIsland(row, col, matrix);
                    islandsCount++;
                }
            }
            return islandsCount;
        }

        private void CheckIsland(int row, int column, int[][] matrix)
        {
            foreach (var direction in _directions)
            {
                var newRow = row + direction[0];
                var newColumn = column + direction[1];

                if (newRow < 0 || newRow >= matrix.Length)
                {
                    continue;
                }

                if (newColumn < 0 || newColumn >= matrix[0].Length)
                {
                    continue;
                }

                if (_visited[newRow, newColumn])
                {
                    continue;
                }

                _visited[newRow, newColumn] = true;
                if (matrix[newRow][newColumn] == 0)
                {
                    continue;
                }
                CheckIsland(newRow, newColumn, matrix);
            }
        }
    }
}
