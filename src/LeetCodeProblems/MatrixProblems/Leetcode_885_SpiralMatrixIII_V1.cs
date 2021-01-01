using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix-iii/
    /// </summary>
    public class Leetcode_885_SpiralMatrixIII_V1
    {
        private IList<(int row, int column)> path;

        //Row variables
        private int startRow = -1;
        private int endRow = -1;
        private int rowLength = -1;

        //Column variables
        private int startColumn = -1;
        private int endColumn = -1;
        private int columnLength = -1;


        public int[][] SpiralMatrix(int rows, int columns, int currentRow, int currentColumn)
        {
            throw new NotImplementedException();
        }
    }
}
