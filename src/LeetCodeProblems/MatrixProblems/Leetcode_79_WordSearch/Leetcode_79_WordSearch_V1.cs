using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_79_WordSearch
{
    /// <summary>
    /// https://leetcode.com/problems/word-search/
    /// </summary>
    public class Leetcode_79_WordSearch_V1
    {                
        public bool WordExists(char[][] matrix, string word)
        {
            var exists = false;
            var rows = matrix.Length;
            var columns = matrix[0].Length;
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    var result = WordExists(matrix, word, 0, i, j);
                    if (result)
                    {
                        exists = true;
                        break;
                    }
                }
            }

            return exists;
        }

        private bool WordExists(char[][] matrix, string word, int index, int row, int column)
        {
            if (index >= word.Length)
            {
                return true;
            }

            if (row < 0 || column < 0)
            {
                return false;
            }

            if (row >= matrix.Length || column >= matrix[0].Length)
            {
                return false;
            }

            if (matrix[row][column] == '0')
            {
                return false;
            }

            if (matrix[row][column] != word[index])
            {
                return false;
            }

            var temp = matrix[row][column];
            matrix[row][column] = '0';
            var result = WordExists(matrix, word, index + 1, row + 1, column)
                || WordExists(matrix, word, index + 1, row - 1, column)
                || WordExists(matrix, word, index + 1, row, column + 1)
                || WordExists(matrix, word, index + 1, row, column - 1);
            matrix[row][column] = temp;
            return result;
        }
    }
}
