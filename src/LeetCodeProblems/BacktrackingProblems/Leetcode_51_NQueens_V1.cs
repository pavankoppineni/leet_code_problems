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
        private IList<int[]> _solutions;
        private HashSet<int> _filledColumns;
        public IList<IList<string>> FindSolutions(int n)
        {
            _filledColumns = new HashSet<int>();
            _solutions = new List<int[]>();
            return null;
        }

        private void FindSolution(int queenCount, int length, int[] position)
        {
            if (queenCount <= 0)
            {
                _solutions.Add(position.ToArray());
                return;
            }

            for (var index = 0; index < length; index++)
            {
                if (_filledColumns.Contains(index))
                {
                    continue;
                }
                _filledColumns.Add(index);
                position[queenCount] = index;
                FindSolution(queenCount + 1, length, position);
                position[queenCount] = -1;
                _filledColumns.Remove(index);
            }
        }
    }
}
