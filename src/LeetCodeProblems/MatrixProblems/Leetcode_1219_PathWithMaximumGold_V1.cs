using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/path-with-maximum-gold/
    /// </summary>
    public class Leetcode_1219_PathWithMaximumGold_V1
    {
        private int[][] _grid;
        private int _rowCount;
        private int _columnCount;
        private int[,] _directors = new int[,]
        {
            { 1, 0 },
            {-1, 0 },
            { 0, 1 },
            { 0, -1 }
        };
        private bool[,] _visited;

        public int CalculateMaximumGold(int[][] grid)
        {
            _rowCount = grid.Length;
            _columnCount = grid[0].Length;
            _visited = new bool[_rowCount, _columnCount];
            return 0;
        }

        private void CalculateMaximumGold(int row, int column, int maxGold)
        {
            if (row < 0 || column < 0)
            {
                return;
            }

            if (row >= _rowCount || column >= _columnCount)
            {
                return;
            }

            if (_visited[row, column])
            {
                return;
            }

            if (_grid[row][column] == 0)
            {
                return;
            }

            _visited[row, column] = true;
            foreach (var direction in _directors)
            {
            }
        }
    }
}
