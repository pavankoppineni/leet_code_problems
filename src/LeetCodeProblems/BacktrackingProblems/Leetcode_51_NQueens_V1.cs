using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/n-queens/
    /// </summary>
    public class Leetcode_51_NQueens_V1
    {
        private int _rows;
        private FilledPositions _filledPositions;
        private IList<Position[]> _validPositions;
        private IList<IList<string>> _result;

        public IList<IList<string>> FindSolutions(int n)
        {
            _rows = n;
            _filledPositions = new FilledPositions(n);
            _validPositions = new List<Position[]>();
            _result = new List<IList<string>>();
            FindSolution(0, new Position[n]);
            return _result;
        }

        private IList<string> ToPositionStrings(Position[] positions)
        {
            var result = new List<string>();
            for (var row = 0; row < _rows; row++)
            {
                var sb = new StringBuilder();
                for (var column = 0; column < _rows; column++)
                {
                    if (positions[row].Column == column)
                    {
                        sb.Append('Q');
                    }
                    else
                    {
                        sb.Append('.');
                    }
                }
                result.Add(sb.ToString());
            }

            return result;
        }

        private void FindSolution(int queenIndex, Position[] positions)
        {
            if (queenIndex >= _rows)
            {
                _validPositions.Add(positions.ToArray());
                var positionStrings = ToPositionStrings(positions);
                _result.Add(positionStrings);
                return;
            }

            for (var column = 0; column < _rows; column++)
            {
                var canFillPosition = _filledPositions.CanPlaceQueen(queenIndex, column);
                if (!canFillPosition)
                {
                    continue;
                }

                _filledPositions.AddPosition(queenIndex, column);
                var position = new Position
                {
                    Row = queenIndex,
                    Column = column
                };
                positions[queenIndex] = position;
                FindSolution(queenIndex + 1, positions);
                positions[queenIndex] = null;
                _filledPositions.RemovePosition(queenIndex, column);
            }
        }
    }

    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }
    }

    public class FilledPositions
    {
        private readonly int _rows;
        public FilledPositions(int rows)
        {
            _rows = rows;
            FilledColumns = new HashSet<int>();
            FilledRows = new HashSet<int>();
            FilledLeftDiagonals = new HashSet<int>();
            FilledRightDiagonals = new HashSet<int>();
        }

        public HashSet<int> FilledColumns { get; private set; }
        public HashSet<int> FilledRows { get; private set; }
        public HashSet<int> FilledLeftDiagonals { get; private set; }
        public HashSet<int> FilledRightDiagonals { get; private set; }

        public void AddPosition(int row, int column)
        {
            FilledColumns.Add(column);
            FilledRows.Add(row);
            FilledRightDiagonals.Add(column + row);
            FilledLeftDiagonals.Add(row + (_rows - column - 1));
        }

        public void RemovePosition(int row, int column)
        {
            FilledColumns.Remove(column);
            FilledRows.Remove(row);
            FilledRightDiagonals.Remove(column + row);
            FilledLeftDiagonals.Remove(row + (_rows - column - 1));
        }

        public bool CanPlaceQueen(int row, int column)
        {
            var canPlace = FilledRows.Contains(row)
                || FilledColumns.Contains(column)
                || FilledRightDiagonals.Contains(row + column)
                || FilledLeftDiagonals.Contains(row + (_rows - column - 1));
            return !canPlace;
        }

        private IEnumerable<HashSet<int>> GetAllSets()
        {
            yield return FilledColumns;
            yield return FilledRows;
            yield return FilledLeftDiagonals;
        }
    }
}
