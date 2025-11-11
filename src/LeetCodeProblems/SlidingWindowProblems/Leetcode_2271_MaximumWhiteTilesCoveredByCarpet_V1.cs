using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-white-tiles-covered-by-a-carpet/description/
    /// </summary>
    public class Leetcode_2271_MaximumWhiteTilesCoveredByCarpet_V1
    {
        public int CalcualteMaximumWhiteTiles(int[][] tiles, int carpetLen)
        {
            var comparer = new TilesComparaer();
            Array.Sort(tiles, comparer);
            for (var index = 1; index < tiles.Length; index++)
            {
                var tile = tiles[index];
                var tileLength = tile[1] - tile[0];
            }

            return 1;
        }
    }

    public class TilesComparaer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[0].CompareTo(y[0]);
        }
    }
}
