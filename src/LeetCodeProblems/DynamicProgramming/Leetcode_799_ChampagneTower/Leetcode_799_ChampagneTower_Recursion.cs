using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_799_ChampagneTower
{
    /// <summary>
    /// https://leetcode.com/problems/champagne-tower/
    /// </summary>
    public class Leetcode_799_ChampagneTower_Recursion
    {
        private IDictionary<int, double> _table;
        public double ChampagneTower(int glassCount, int rowIndex, int glassIndex)
        {
            if (rowIndex == 0)
            {
                return glassCount >= 1 ? 1 : 0;
            }
            _table = new Dictionary<int, double>();
            var left = CalculateWineQuantity(glassCount, rowIndex - 1, glassIndex - 1);
            var right = CalculateWineQuantity(glassCount, rowIndex - 1, glassIndex);
            var total = left + right;
            return total >= 1 ? 1 : total;
        }

        private double CalculateWineQuantity(int glassCount, int rowIndex, int glassIndex)
        {
            if (glassIndex < 0 || glassIndex >= rowIndex + 1)
            {
                return 0;
            }

            var offsetIndex = (rowIndex * (rowIndex + 1)) / 2;
            if (_table.ContainsKey(offsetIndex + glassIndex))
            {
                return _table[offsetIndex + glassIndex];
            }

            if (rowIndex == 0)
            {
                var remainingCount = glassCount - 1;
                if (remainingCount > 0)
                {
                    return remainingCount / 2.0;
                }
                return 0;
            }
            var left = CalculateWineQuantity(glassCount, rowIndex - 1, glassIndex - 1);
            var right = CalculateWineQuantity(glassCount, rowIndex - 1, glassIndex);
            var sum = left + right;
            var remSum = sum - 1;
            if (remSum > 0)
            {
                _table.Add(offsetIndex + glassIndex, remSum / 2.0);
                return remSum / 2.0;
            }
            _table.Add(offsetIndex + glassIndex, 0);
            return 0;
        }
    }
}
