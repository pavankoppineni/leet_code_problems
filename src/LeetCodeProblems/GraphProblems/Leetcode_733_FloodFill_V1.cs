using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GraphProblems
{
    /// <summary>
    /// https://leetcode.com/problems/flood-fill/
    /// </summary>
    public class Leetcode_733_FloodFill_V1
    {
        private int[][] _image;
        private int _rowCount;
        private int _columnCount;
        private readonly int[][] _directions = new int[4][]
        {
            new int[]{ 0, 1},
            new int[]{ 0, -1},
            new int[]{1, 0},
            new int[]{ -1, 0},
        };
        private int _newColor;
        private int _cellColor;
        private bool[,] _visited;
        public int[][] FloodFill(int[][] image, int row, int column, int newColor)
        {
            _rowCount = image.Length;
            _columnCount = image[0].Length;
            _newColor = newColor;
            _visited = new bool[_rowCount, _columnCount];
            _image = image;
            _cellColor = image[row][column];
            FloodFill(row, column);
            return image;
        }

        private void FloodFill(int row, int column)
        {
            //Case 1 : Row is greater than _rowCount or less than zero
            //Action : Do nothing
            if (row >= _rowCount || row < 0)
            {
                return;
            }

            //Case 2 : Column is greater than _columnCount or less than zero
            //Action : Do nothing
            if (column >= _columnCount || column < 0)
            {
                return;
            }

            //Case 3 : If cell is visited
            //Action : Do nothing
            if (_visited[row, column])
            {
                return;
            }

            _visited[row, column] = true;
            //Case 4 : Is cell value is not equal to cell color
            //Action : Do nothing
            if (_image[row][column] != _cellColor)
            {
                return;
            }

            _image[row][column] = _newColor;
            foreach (var direction in _directions)
            {
                FloodFill(row + direction[0], column + direction[1]);
            }
        }
    }
}
