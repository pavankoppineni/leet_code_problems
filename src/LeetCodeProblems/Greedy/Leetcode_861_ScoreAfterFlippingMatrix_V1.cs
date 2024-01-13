using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// 
    /// </summary>
    public class Leetcode_861_ScoreAfterFlippingMatrix_V1
    {
        public int CalculateMatrixScore(int[][] grid)
        {
            var rowCount = grid.Length;
            var maxPower = grid[0].Length - 1;
            var columnMap = ConstructColumnMap(grid);
            var halfRow = rowCount >> 1;
            double score = 0;
            for (var column = 1; column < rowCount; column++)
            {
                var currentPower = maxPower - column;
                var currentCount = columnMap[column];
                if (currentCount <= halfRow)
                {
                    currentCount = rowCount - currentCount;
                }
                score += currentCount * Math.Pow(2, currentPower);
            }
            score += rowCount * Math.Pow(2, maxPower);
            return (int)score;
        }

        private int[] ConstructColumnMap(int[][] grid)
        {
            var columnMap = new int[grid.Length];
            for (var row = 0; row < grid.Length; row++)
            {
                var toggle = grid[row][0] == 0;
                for (var col = 1; col < grid[row].Length; col++)
                {
                    var value = grid[row][col];
                    if (toggle)
                    {
                        value = 1 - grid[row][col];
                    }
                    if (value == 1)
                    {
                        columnMap[col] += 1;
                    }
                }
            }
            return columnMap;
        }
    }
}
