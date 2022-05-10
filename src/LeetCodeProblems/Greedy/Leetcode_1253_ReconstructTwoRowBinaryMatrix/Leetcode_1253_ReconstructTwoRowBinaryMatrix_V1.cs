using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_1253_ReconstructTwoRowBinaryMatrix
{
    /// <summary>
    /// https://leetcode.com/problems/reconstruct-a-2-row-binary-matrix/
    /// </summary>
    public class Leetcode_1253_ReconstructTwoRowBinaryMatrix_V1
    {
        public IList<IList<int>> ConstructBinaryMatrix(int upperSum, int lowerSum, int[] columnSum)
        {
            var binaryMatrix = new List<IList<int>>(2)
            {
                new List<int>(columnSum.Length),
                new List<int>(columnSum.Length)
            };
            for (var colIndex = 0; colIndex < columnSum.Length; colIndex++)
            {
                binaryMatrix[0].Add(0);
                binaryMatrix[1].Add(0);
                if (columnSum[colIndex] == 2)
                {
                    columnSum[colIndex] = 0;
                    upperSum -= 1;
                    lowerSum -= 1;
                    binaryMatrix[0][colIndex] = 1;
                    binaryMatrix[1][colIndex] = 1;
                }
            }
            for (var colIndex = 0; colIndex < columnSum.Length; colIndex++)
            {
                if (columnSum[colIndex] == 1)
                {
                    if (upperSum > 0)
                    {
                        upperSum -= 1;
                        columnSum[colIndex] -= 1;
                        binaryMatrix[0][colIndex] = 1;
                    }
                    else
                    {
                        lowerSum -= 1;
                        columnSum[colIndex] -= 1;
                        binaryMatrix[1][colIndex] = 1;
                    }
                }
            }
            if (upperSum == 0 && lowerSum == 0)
            {
                return binaryMatrix;
            }
            return new List<IList<int>>();
        }
    }
}
