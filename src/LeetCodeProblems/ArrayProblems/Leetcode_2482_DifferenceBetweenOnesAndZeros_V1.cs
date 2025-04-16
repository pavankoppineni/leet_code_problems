using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/difference-between-ones-and-zeros-in-row-and-column/description
    /// </summary>
    public class Leetcode_2482_DifferenceBetweenOnesAndZeros_V1
    {
        public int[][] CalculateOnesAndZeros(int[][] grid)
        {
            var rowColLookup = ConstructLookup(grid);
            return CalculateDifference(grid, rowColLookup);
        }

        private static int[][] CalculateDifference(int[][] grid, RowColLookup rowColLookup)
        {
            var rowCount = grid.Length;
            var colCount = grid[0].Length;
            var difference = new int[rowCount][];
            for (var row = 0; row < rowCount; row++)
            {
                difference[row] = new int[colCount];
                for (var col = 0; col < colCount; col++)
                {
                    var onesRowCount = rowColLookup.RowLookup[row];
                    var onesColCount = rowColLookup.ColLookup[col];
                    var zerosRowCount = colCount - onesRowCount;
                    var zerosColCount = rowCount - onesColCount;
                    difference[row][col] = onesRowCount + onesColCount - (zerosRowCount + zerosColCount);
                }
            }

            return difference;
        }

        private static RowColLookup ConstructLookup(int[][] grid)
        {
            var rowLookup = new Dictionary<int, int>();
            var colLookup = new Dictionary<int, int>();
            for (var row = 0; row < grid.Length; row++)
            {
                for (var col = 0; col < grid[row].Length; col++)
                {
                    var value = grid[row][col];
                    if (rowLookup.ContainsKey(row))
                    {
                        rowLookup[row] += value;
                    }
                    else
                    {
                        rowLookup.Add(row, value);
                    }

                    if (colLookup.ContainsKey(col))
                    {
                        colLookup[col] += value;
                    }
                    else
                    {
                        colLookup.Add(col, value);
                    }
                }
            }

            return new RowColLookup
            {
                RowLookup = rowLookup,
                ColLookup = colLookup
            };
        }
    }

    public class RowColLookup
    {
        public IDictionary<int, int> RowLookup { get; set; }
        public IDictionary<int, int> ColLookup { get; set; }
    }
}
