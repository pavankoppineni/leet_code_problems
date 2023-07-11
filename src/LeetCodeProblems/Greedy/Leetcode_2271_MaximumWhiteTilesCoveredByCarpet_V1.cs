using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-white-tiles-covered-by-a-carpet/
    /// </summary>
    public class Leetcode_2271_MaximumWhiteTilesCoveredByCarpet_V1
    {
        public int CalculateMaximumTilesCovered(int[][] tiles, int carpetLength)
        {
            var lastTile = -1;
            foreach (var tile in tiles)
            {
                if (tile[1] > lastTile)
                {
                    lastTile = tile[1];
                }
            }
            var tilePrefix = new int[lastTile + 1];
            foreach (var tile in tiles)
            {
                var start = tile[0];
                var end = tile[1];
                tilePrefix[start] = 1;
                tilePrefix[end + 1] = -1;
            }

            for (var index = 1; index < tilePrefix.Length; index++)
            {
                tilePrefix[index] += tilePrefix[index - 1];
            }

            var maximumTilesCovered = 0;
            for (var index = 1; index < tilePrefix.Length - carpetLength; index++)
            {

            }
            return maximumTilesCovered;
        }
    }
}
