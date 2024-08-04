using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-enclaves/
    /// </summary>
    public class Leetcode_1020_NumberOfEnclaves_V1
    {
        private int[][] _directions = new int[4][]
        {
            new int[] {0,1 },
            new int[] {0,-1 },
            new int[] {1,0 },
            new int[] {-1,0 }
        };
        private int _rows;
        private int _cols;
        private int[][] _grid;
        private ISet<(int row, int column)> _visited;

        public int CalculateNumberofEnclaves(int[][] grid)
        {
            var count = 0;
            _grid = grid;
            _rows = grid.Length;
            _cols = grid[0].Length;
            _visited = new HashSet<(int row, int column)>();
            for (var row = 1; row < _rows - 1; row++)
            {
                for (var column = 1; column < _cols - 1; column++)
                {
                    if (grid[row][column] == 0)
                    {
                        continue;
                    }
                    var area = new Area();
                    var resultArea = CalculateArea(row, column, area);
                    if (resultArea.Isolated)
                    {
                        count += resultArea.CellCount;
                    }
                }
            }
            return count;
        }

        private Area CalculateArea(int row, int column, Area area)
        {
            if (row < 0 || row >= _rows)
            {
                return area;
            }

            if (column < 0 || column >= _cols)
            {
                return area;
            }

            if (_visited.Contains((row, column)))
            {
                return area;
            }

            if (_grid[row][column] == 0)
            {
                return area;
            }

            _visited.Add((row, column));
            area.CellCount += 1;
            if (row == 0 || row == _rows - 1 || column == 0 || column == _cols - 1)
            {
                area.Isolated = false;
            }

            foreach (var direction in _directions)
            {
                CalculateArea(row + direction[0], column + direction[1], area);
            }
            return area;
        }
    }

    internal class Area
    {
        internal int CellCount { get; set; }
        internal bool Isolated { get; set; } = true;
    }
}
