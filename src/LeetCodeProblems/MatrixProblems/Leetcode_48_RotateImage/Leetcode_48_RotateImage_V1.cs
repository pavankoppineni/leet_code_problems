using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_48_RotateImage
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-image/
    /// </summary>
    public class Leetcode_48_RotateImage_V1
    {
        public int[][] RotateImage(int[][] image)
        {
            ReverseRows(image);
            var row = 0;
            var col = image.Length - 1;
            var size = image.Length;
            while (true)
            {
                if (row >= image.Length || col < 0)
                {
                    break;
                }
                SwapEdges(image, size, row, col);
                size--;
                row++;
                col--;
            }
            return image;
        }

        private void SwapEdges(int[][] image, int matrixSize, int row, int col)
        {
            var transientCol = 0;
            var transientRow = image.Length - 1;
            while (true)
            {
                if (transientCol >= matrixSize || transientRow < 0)
                {
                    break;
                }
                var cellOne = image[row][transientCol];
                image[row][transientCol] = image[transientRow][col];
                image[transientRow][col] = cellOne;
                transientCol++;
                transientRow--;
            }
        }

        private int[][] ReverseRows(int[][] image)
        {
            var rows = image.Length;
            var columns = image[0].Length;
            for (var row = 0; row < rows; row++)
            {
                var firstColumn = 0;
                var lastColumn = columns - 1;
                while (firstColumn < lastColumn)
                {
                    var temp = image[row][firstColumn];
                    image[row][firstColumn] = image[row][lastColumn];
                    image[row][lastColumn] = temp;
                    firstColumn++;
                    lastColumn--;
                }
            }
            return image;
        }
    }
    
}
