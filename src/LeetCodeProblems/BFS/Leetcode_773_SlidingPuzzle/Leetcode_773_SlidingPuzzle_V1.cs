using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BFS.Leetcode_773_SlidingPuzzle
{
    /// <summary>
    /// https://leetcode.com/problems/sliding-puzzle/
    /// </summary>
    public class Leetcode_773_SlidingPuzzle_V1
    {
        private int[][] _directions;
        private int[][] _board;
        private bool[] _visited;
        private string _target;
        public int CalculateMinimumSlides(int[][] board)
        {
            _target = "123450";
            _visited = new bool[6];
            _directions = new int[6][]
            {
                new int[]{1,3},
                new int[]{0,2,4},
                new int[]{1,5},
                new int[]{0,4},
                new int[]{3,5,1},
                new int[]{4,2}
            };
            _board = board;
            return -1;
        }

        private int CalculateMinimumSlides(int index)
        {
            var currentDirections = _directions[index];
            foreach (var direction in currentDirections)
            {

            }
            return -1;
        }
    }
}
