using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_2320_CountNumberOfWaysToPlaceHouses
{
    /// <summary>
    /// https://leetcode.com/problems/count-number-of-ways-to-place-houses/
    /// </summary>
    public class Leetcode_2320_CountNumberOfWaysToPlaceHouses_V1
    {
        private IDictionary<string, double> _lookup = new Dictionary<string, double>();
        private int _plots;
        public int CalculateNumberOfPlacements(int plots)
        {
            _plots = plots;
            var totalWays = FindWays(0);
            var numerator = totalWays * totalWays;
            return (int)(numerator % 1000000007);
        }

        private double FindWays(int level, PlotType? plotType = null)
        {
            var key = $"{level}_{plotType}";
            if (_lookup.ContainsKey(key))
            {
                return _lookup[key];
            }

            if (level == _plots)
            {
                return 1;
            }

            var right = plotType == PlotType.Occupied ? 0 : FindWays(level + 1, PlotType.Occupied);
            var left = FindWays(level + 1, PlotType.Empty);
            var totalWays = left + right;
            _lookup.Add(key, totalWays);
            return totalWays;
        }
    }

    public enum PlotType
    {
        Occupied,
        Empty
    }
}
