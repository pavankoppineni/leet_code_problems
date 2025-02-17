using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-falling-path-sum-ii/
    /// </summary>
    public class Leetcode_1289_MinimumFallingPathSumII_V1
    {
        private int _rows;
        private int _columns;
        private int[][] _grid;
        private IDictionary<int, IList<ColumnValue>> _lookup;
        public int CalculateMinimumFallingPath(int[][] grid)
        {
            _rows = grid.Length;
            _columns = grid[0].Length;
            _grid = grid;
            if (_columns == 1)
            {
                return grid[0][0];
            }

            _lookup = ConstructLookup(grid);
            var first = CalculateMinimumFallingPath(0, -1);
            var last = CalculateMinimumFallingPath(0, 0);
            return Math.Min(first, last);
        }

        private static IDictionary<int, IList<ColumnValue>> ConstructLookup(int[][] grid)
        {
            var lookup = new Dictionary<int, IList<ColumnValue>>();
            for (var row = 0; row < grid.Length; row++)
            {
                lookup.Add(row, ColumnValue.SortAndCreate(grid[row]));
            }
            return lookup;
        }

        private int CalculateMinimumFallingPath(int row, int excludedCol)
        {
            if (row >= _rows)
            {
                return 0;
            }

            var columnValues = _lookup[row];
            var firstColumn = columnValues[0];
            var secondColumn = columnValues[1];
            if (firstColumn.Index != excludedCol)
            {
                return firstColumn.Value + CalculateMinimumFallingPath(row + 1, firstColumn.Index);
            }
            return secondColumn.Value + CalculateMinimumFallingPath(row + 1, secondColumn.Index);
        }
    }

    public class ColumnValue
    {
        public int Index { get; set; }
        public int Value { get; set; }

        public static IList<ColumnValue> SortAndCreate(int[] values)
        {
            var sortedList = new List<ColumnValue>();
            for (var index = 0; index < values.Length; index++)
            {
                var columnValue = Create(index, values[index]);
                sortedList.Add(columnValue);
            }
            var result = sortedList
                .OrderBy(item => item.Value)
                .ToList();
            return new List<ColumnValue>
            {
                result[0],
                result[1],
            };
        }

        private static ColumnValue Create(int index, int value)
        {
            return new ColumnValue
            { 
                Index = index, 
                Value = value 
            };
        }
    }
}
