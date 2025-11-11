using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-safest-path-in-a-grid
    /// </summary>
    public class Leetcode_2812_FindTheSafestPathInGrid_V1
    {
        private static IList<(int row, int col)> _directions = new List<(int row, int col)>
        {
            (0, 1), //Right
            (0, -1), //Left
            (1, 0), //Down
            (-1, 0) //Up
        };
        public int CalculateSafenessFactor(IList<IList<int>> grid)
        {
            if (grid.Count == 0)
            {
                return 0;
            }

            var rows = grid.Count;
            var cols = grid[0].Count;
            if (grid[0][0] == 1 || grid[rows - 1][cols - 1] == 1)
            {
                return 0;
            }

            var distanceGrid = PrecalulateMaximumDistance(grid);
            return 0;
        }

        private int Calculate(int[][] distanceGrid, int row, int col)
        {
            return 0;
        }

        private int[][] PrecalulateMaximumDistance(IList<IList<int>> grid)
        {
            var rows = grid.Count;
            var cols = grid[0].Count;
            var distanceGrid = new int[rows][];
            var visited = new bool[rows][];
            var queue = new Queue<(int row, int column)>();
            for (var row = 0; row < rows; row++)
            {
                visited[row] = new bool[cols];
                distanceGrid[row] = new int[cols];
                for (var col = 0; col < cols; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        distanceGrid[row][col] = 0;
                        visited[row][col] = true;
                        queue.Enqueue((row, col));
                    }
                }
            }

            while (queue.Count > 0)
            {
                var cell = queue.Dequeue();
                foreach (var direction in _directions)
                {
                    var newRow = cell.row + direction.row;
                    var newCol = cell.column + direction.col;
                    if (newRow < 0 || newRow >= rows)
                    {
                        continue;
                    }

                    if (newCol < 0 || newCol >= cols)
                    {
                        continue;
                    }

                    if (visited[newRow][newCol])
                    {
                        continue;
                    }

                    visited[newRow][newCol] = true;
                    distanceGrid[newRow][newCol] = distanceGrid[cell.row][cell.column] + 1;
                    queue.Enqueue((newRow, newCol));
                }
            }

            return distanceGrid;
        }
    }
}
