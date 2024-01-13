using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/corporate-flight-bookings/
    /// </summary>
    public class Leetcode_1109_CorporateFlightBookings_V1
    {
        public int[] CalculateFlightBookings(int[][] bookings, int n)
        {
            var flightMap = new int[n + 1];
            foreach (var booking in bookings)
            {
                flightMap[booking[0] - 1] = booking[2];
                flightMap[booking[1] + 1] -= booking[3];
            }
            for (var index = 1; index < n; index++)
            {
                flightMap[index] += flightMap[index - 1];
            }
            return flightMap.AsSpan(0, n).ToArray();
        }
    }
}
