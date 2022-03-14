using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BFS.Leetcode_994_RottingOranges
{
    /// <summary>
    /// https://leetcode.com/problems/rotting-oranges/
    /// </summary>
    public class Leetcode_994_RottingOranges_V1
    {
        private int[][] _directions;
        private bool[,] _visited;
        private int[,] _time;
        public Leetcode_994_RottingOranges_V1()
        {
            _directions = new int[][]
            {
                new int[]{0,1 },
                new int[]{0, -1 },
                new int[]{1, 0 },
                new int[]{-1, 0 },
            };
        }

        public int CalculateMinimumMinutesToRot(int[][] grid)
        {
            var maxTime = 0;
            var rows = grid.Length;
            var cols = grid[0].Length;
            _visited = new bool[rows, cols];
            _time = new int[rows, cols];
            var queue = new Queue<(int row, int col)>();
            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    if (grid[row][col] == 2)
                    {
                        _time[row, col] = 0;
                        _visited[row, col] = true;
                        queue.Enqueue((row, col));
                    }
                }
            }

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                foreach (var direction in _directions)
                {
                    var newRow = item.row + direction[0];
                    var newCol = item.col + direction[1];
                    if (newCol >= cols || newCol < 0)
                    {
                        continue;
                    }
                    if (newRow >= rows || newRow < 0)
                    {
                        continue;
                    }
                    if (_visited[newRow, newCol])
                    {
                        continue;
                    }
                    if (grid[newRow][newCol] == 0)
                    {
                        _visited[newRow, newCol] = true;
                        continue;
                    }
                    _time[newRow, newCol] = _time[item.row, item.col] + 1;
                    maxTime = Math.Max(maxTime, _time[newRow, newCol]);
                    queue.Enqueue((newRow, newCol));
                    _visited[newRow, newCol] = true;
                }
            }

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        if (_time[row, col] == 0)
                        {
                            maxTime = -1;
                            break;
                        }
                    }
                }
            }

            return maxTime;
        }
    }
}
