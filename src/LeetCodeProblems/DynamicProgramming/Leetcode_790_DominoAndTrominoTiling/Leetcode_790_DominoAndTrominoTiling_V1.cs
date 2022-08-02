using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_790_DominoAndTrominoTiling
{
    /// <summary>
    /// https://leetcode.com/problems/domino-and-tromino-tiling/
    /// </summary>
    public class Leetcode_790_DominoAndTrominoTiling_V1
    {
        private IDictionary<int, int> _lookup = new Dictionary<int, int>();
        public int CalculateDominoTiling(int number)
        {
            if (number < 0)
            {
                return 0;
            }

            if (number == 1)
            {
                return 1;
            }

            if (number == 2)
            {
                return 2;
            }

            if (number == 0)
            {
                return 1;
            }

            var totalWays1 = CalculateDominoTiling(number - 1);
            var totalWays2 = CalculateDominoTiling(number - 2);
            var toalWays3 = 2 * CalculateDominoTiling(number - 3);
            var toalWays4 = 2 * CalculateDominoTiling(number - 4);
            var toalWays5 = 2 * CalculateDominoTiling(number - 5);
            var totalWays6 = 2 * CalculateDominoTiling(number - 6);
            var totalWays7 = CalculateDominoTiling(number - 7);
            return totalWays1 + totalWays2 + toalWays3 + toalWays4 + toalWays5 + totalWays6 + totalWays7;
        }
    }
}
