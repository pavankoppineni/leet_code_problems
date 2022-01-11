using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1094_CarPooling
{
    /// <summary>
    /// https://leetcode.com/problems/car-pooling/
    /// </summary>
    public class Leetcode_1094_CarPooling_V1
    {
        public bool CarPooling(int[][] trips, int capacity)
        {
            var result = true;
            var min = 0;
            var max = 0;
            foreach (var trip in trips)
            {
                min = Math.Min(min, trip[1]);
                max = Math.Max(max, trip[2]);
            }
            var capacityTable = new int[max + 1];
            foreach (var trip in trips)
            {
                capacityTable[trip[1]] += trip[0];
                capacityTable[trip[2]] -= trip[0];
            }
            var previous = 0;
            for (var i = 0; i < capacityTable.Length; i++)
            {
                previous += capacityTable[i];
                if (previous > capacity)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
