using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/magic-squares-in-grid/description/
    /// </summary>
    public class Leetcode_840_MagicSquaresInGrid_V1
    {
        public int CalculateNumberOfMagicGrids(int[][] grid)
        {
            var rows = grid.Length;
            var columns = grid[0].Length;
            var prefixSumGrid = new PrefixGrid(rows, columns);

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    prefixSumGrid.Append(row, col, grid[row][col]);
                }
            }
            return 1;
        }
    }

    public class MagicGridCalculator
    {
        private readonly int _rows;
        private readonly int _columns;
        private readonly PrefixGrid _prefixGrid;
        public MagicGridCalculator(int rows, int columns, PrefixGrid prefixGrid)
        {
            _prefixGrid = prefixGrid;
            _rows = rows;
            _columns = columns;
        }

        public int Calculate()
        {
            for (var row = 2; row < _rows; row++)
            {
                for (var col = 2; col < _columns; col++)
                {
                }
            }
            return 1;
            
        }

        private bool IsMagicGrid(int row, int column)
        {
            var topRow = _prefixGrid.GetCell(row - 2, column).LineSum.LeftToRight;
            var bottomRow = _prefixGrid.GetCell(row, column).LineSum.LeftToRight;
            var leftColumn = _prefixGrid.GetCell(row, column - 2);
            return false;
        }
    }

    public class PrefixGrid
    {
        private readonly int _rows;
        private readonly int _columns;
        private readonly PrefixGridCell[,] _cells;
        public PrefixGrid(int rows, int columns)
        {
            _columns = columns;
            _rows = rows;
            _cells = new PrefixGridCell[rows, columns];
        }

        public void Append(int row, int column, int value)
        {
            var cell = new PrefixGridCell();
            cell.LineSum = CalculateLineSum(row, column, value, cell);
            cell.DiagonalSum = CalculatediagonalSum(row, column, value, cell);
            _cells[row, column] = cell;
        }

        public PrefixGridCell GetCell(int row, int column)
        {
            return _cells[row, column];
        }

        private LineSum CalculateLineSum(int row, int column, int value, PrefixGridCell prefixGridCell)
        {
            var lineSum = new LineSum();
            lineSum.TopToBottom = GetTopLineSum(row, column) + value;
            lineSum.LeftToRight = GetLeftLineSum(row, column) + value;
            return lineSum;
        }

        private DiagonalSum CalculatediagonalSum(int row, int column, int value, PrefixGridCell prefixGridCell)
        {
            var diagonalSum = new DiagonalSum();
            diagonalSum.LeftToRight = GetLeftDiagonalSum(row, column) + value;
            diagonalSum.RightToLeft = GetRightDiagonalSum(row, column) + value;
            return diagonalSum;
        }

        private int GetLeftLineSum(int row, int column)
        {
            if (row < 0 || column < 0)
            {
                return 0;
            }

            if (column - 2 <= 0)
            {
                return _cells[row, column - 1].LineSum.LeftToRight;
            }

            return _cells[row, column - 1].LineSum.LeftToRight - _cells[row, column - 2].LineSum.LeftToRight;
        }

        private int GetTopLineSum(int row, int column)
        {
            if (row < 0 || column < 0)
            {
                return 0;
            }

            if (row - 2 <= 0)
            {
                return _cells[row - 1, column].LineSum.TopToBottom;
            }

            return _cells[row - 1, column].LineSum.TopToBottom - _cells[row - 2, column].LineSum.TopToBottom;
        }

        private int GetLeftDiagonalSum(int row, int column)
        {
            if (row < 0 || column < 0)
            {
                return 0;
            }

            if (row - 2 <= 0)
            {
                return _cells[row - 1, column - 1].DiagonalSum.LeftToRight;
            }

            return _cells[row - 1, column - 1].DiagonalSum.LeftToRight - _cells[row - 2, column - 2].DiagonalSum.LeftToRight;
        }

        private int GetRightDiagonalSum(int row, int column)
        {
            if (row < 0 || column < 0 || column >= _columns)
            {
                return 0;
            }

            if (row - 2 <= 0)
            {
                return _cells[row - 1, column + 1].DiagonalSum.RightToLeft;
            }

            return _cells[row - 1, column + 1].DiagonalSum.RightToLeft - _cells[row - 2, column + 2].DiagonalSum.RightToLeft;
        }

        public struct LineSum
        {
            public int LeftToRight { get; set; }
            public int TopToBottom {  get; set; }
        }

        public struct DiagonalSum
        {
            public int LeftToRight { get; set; }
            public int RightToLeft { get; set; }
        }

        public class PrefixGridCell
        {
            public LineSum LineSum { get; set; }
            public DiagonalSum DiagonalSum { get; set; }
        }
    }
}