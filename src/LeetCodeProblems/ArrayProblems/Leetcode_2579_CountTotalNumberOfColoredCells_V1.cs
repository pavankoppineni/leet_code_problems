using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-total-number-of-colored-cells/
    /// </summary>
    public class Leetcode_2579_CountTotalNumberOfColoredCells_V1
    {
        public int CalculateColoredCells(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            var coloredCells = 1;
            var index = 2;
            while (index <= n)
            {
                coloredCells += (2 * index - 1);
                index += 1;
            }
            index -= 1;
            coloredCells += coloredCells;
            return coloredCells - (2 * index - 1);
        }
    }
}
