using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_240_Search2DMatrix
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix-ii/
    /// </summary>
    public class Leetcode_240_Search2DMatrix_V1
    {
        private int _target;
        private int[][] _matrix;
        private int _columns;
        private int _rows;
        public bool SearchMatrix(int[][] matrix, int target)
        {
            _rows = matrix.Length;
            _columns = matrix[0].Length;
            _matrix = matrix;
            _target = target;
            return SearchForRow(0, _rows - 1);
        }

        private bool SearchForRow(int startRow, int endRow)
        {
            if (startRow == endRow)
            {
                return SearchInRow(startRow, 0, _columns - 1);
            }

            if (startRow > endRow)
            {
                return false;
            }

            var mid = startRow + (endRow - startRow) / 2;
            var lastElementInRow = _matrix[mid][_columns - 1];
            var firstElementInRow = _matrix[mid][0];

            //Case One : When _target is greater than last value in row
            //Action : Search bottom section of matrix
            if (_target > lastElementInRow)
            {
                return SearchForRow(mid + 1, endRow);
            }

            //Case Two : When _target is less than first value in row
            //Action : Search top section of matrix
            if (_target < firstElementInRow)
            {
                return SearchForRow(startRow, mid - 1);
            }

            //Case Three : When  _target is greater than first value of row and less than last value of row
            //Action : Search top section of matrix including current row
            var searchTop = SearchForRow(startRow, mid);
            if (searchTop)
            {
                return true;
            }
            return SearchForRow(mid + 1, endRow);
        }

        private bool SearchInRow(int row, int startColumn, int endColumn)
        {
            if (startColumn > endColumn)
            {
                return false;
            }

            var mid = startColumn + (endColumn - startColumn) / 2;
            var value = _matrix[row][mid];
            if (value == _target)
            {
                return true;
            }

            if (_target < value)
            {
                return SearchInRow(row, startColumn, mid - 1);
            }
            return SearchInRow(row, mid + 1, endColumn);
        }
    }
}
