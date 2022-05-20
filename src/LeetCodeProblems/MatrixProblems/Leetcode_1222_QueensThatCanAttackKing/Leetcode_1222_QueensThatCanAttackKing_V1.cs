using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_1222_QueensThatCanAttackKing
{
    /// <summary>
    /// https://leetcode.com/problems/queens-that-can-attack-the-king/
    /// </summary>
    public class Leetcode_1222_QueensThatCanAttackKing_V1
    {
        private IDictionary<int, int[]> _queensLookup;
        private IList<IList<int>> _queens;

        public IList<IList<int>> Calculate(int[][] queens, int[] king)
        {
            _queens = new List<IList<int>>();
            _queensLookup = new Dictionary<int, int[]>();
            foreach (var queen in queens)
            {
                _queensLookup.Add(queen[0] * 8 + queen[1], queen);
            }
            CalculateDiagonalAttacks(king);
            CalculateHorizontalAttacks(king);
            CalculateVerticalAttacks(king);
            return _queens;
        }

        private void CalculateVerticalAttacks(int[] king)
        {
            var row = king[0];
            var col = king[1];

            //Action : Calculate top queens
            for (var currentRow = row - 1; currentRow >= 0; currentRow--)
            {
                var pos = currentRow * 8 + col;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { currentRow, col });
                    break;
                }
            }

            //Action : Calculate bottom queens
            for (var currentRow = row + 1; currentRow < 8; currentRow++)
            {
                var pos = currentRow * 8 + col;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { currentRow, col });
                    break;
                }
            }
        }

        private void CalculateHorizontalAttacks(int[] king)
        {
            var row = king[0];
            var col = king[1];

            //Action : Calculate right queens
            for (var column = col + 1; column < 8; column++)
            {
                var pos = row * 8 + column;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { row, column });
                    break;
                }
            }

            //Action : Calculate left queens
            for (var column = col - 1; column >= 0; column--)
            {
                var pos = row * 8 + column;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { row, column });
                    break;
                }
            }
        }

        private void CalculateDiagonalAttacks(int[] king)
        {
            var row = king[0] + 1;
            var column = king[1] + 1;
            while (row < 8 && column < 8)
            {
                var pos = row * 8 + column;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { row, column });
                    break;
                }
                row++;
                column++;
            }

            row = king[0] - 1;
            column = king[1] - 1;
            while (row >= 0 && column >= 0)
            {
                var pos = row * 8 + column;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { row, column });
                    break;
                }
                row--;
                column--;
            }

            row = king[0] - 1;
            column = king[1] + 1;
            while (row >= 0 && column < 8)
            {
                var pos = row * 8 + column;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { row, column });
                    break;
                }
                row--;
                column++;
            }

            row = king[0] + 1;
            column = king[1] - 1;
            while (row < 8 && column >= 0)
            {
                var pos = row * 8 + column;
                if (_queensLookup.ContainsKey(pos))
                {
                    _queens.Add(new int[] { row, column });
                    break;
                }
                row++;
                column--;
            }
        }
    }
}
