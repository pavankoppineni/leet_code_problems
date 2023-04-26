using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/valid-sudoku/
    /// </summary>
    public class Leetcode_36_ValidateSudoku_V1
    {
        public bool Validate(char[][] board)
        {
            var rowLookup = new int[9];
            var columnLookup = new int[9];

            for (var row = 0; row < 9; row++)
            {
                for (var column = 0; column < 9; column++)
                {
                    if (board[row][column] == '.')
                    {
                        continue;
                    }
                    var value = board[row][column] - '1';
                    var rowValue = rowLookup[row] & (1 << value);
                    if (rowValue > 0)
                    {
                        return false;
                    }


                    var colValue = columnLookup[column] & (1 << value);
                    if (colValue > 0)
                    {
                        return false;
                    }

                    rowLookup[row] |= 1 << value;
                    columnLookup[column] |= 1 << value;
                }
            }
            return true;
        }
    }
}
