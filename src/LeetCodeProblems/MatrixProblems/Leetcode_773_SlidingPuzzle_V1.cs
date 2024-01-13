using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sliding-puzzle/
    /// </summary>
    public class Leetcode_773_SlidingPuzzle_V1
    {
        public int CalculateMinimumMoves(int[][] puzzle)
        {
            var (currentState, emptyIndex) = ConstructCurrentState(puzzle);
            return -1;
        }

        private (string currentState, int emptyIndex) ConstructCurrentState(int[][] puzzle)
        {
            var currentState = new char[6];
            var currentIndex = 0;
            var emptyIndex = -1;
            for (var row = 0; row <= 1; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    if (puzzle[row][col] == 0)
                    {
                        emptyIndex = currentIndex;
                    }
                    currentState[currentIndex] = Convert.ToChar(puzzle[row][col]);
                    currentIndex += 1;
                }
            }
            return (new string(currentState), emptyIndex);
        }
    }
}
