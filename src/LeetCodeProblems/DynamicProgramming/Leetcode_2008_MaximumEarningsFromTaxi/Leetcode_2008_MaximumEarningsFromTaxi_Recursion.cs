using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_2008_MaximumEarningsFromTaxi
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-earnings-from-taxi/
    /// </summary>
    public class Leetcode_2008_MaximumEarningsFromTaxi_Recursion
    {
        private int[][] _trips;
        private long[] _stopsTable;
        public long CalculateMaximumEarnings(int stops, int[][] trips)
        {
            _stopsTable = new long[stops + 1];
            _trips = trips;
            Array.Sort(_trips, new TripComparer());
            long maxEarnings = 0;
            for (var index = _trips.Length - 1; index >= 0; index--)
            {
                var currentTrip = _trips[index];
                long currentEarning = currentTrip[1] - currentTrip[0] + currentTrip[2];
                var nextIndex = FindNextTrip(index + 1, _trips.Length - 1, currentTrip[1]);
                if (nextIndex < 0)
                {
                    if (index < _trips.Length - 1)
                    {
                        var nIndex = index + 1;
                        var nextTrip = _trips[nIndex];
                        _stopsTable[currentTrip[0]] = Math.Max(_stopsTable[nextTrip[0]], currentEarning);
                    }
                    else
                    {
                        _stopsTable[currentTrip[0]] = currentEarning;
                    }
                    continue;
                }
                var max = _stopsTable[_trips[nextIndex][0]];
                currentEarning = Math.Max(currentEarning + max, _stopsTable[index + 1]);
                _stopsTable[currentTrip[0]] = currentEarning;
                maxEarnings = currentEarning;
            }
            return maxEarnings;
        }

        private long FindNextTrip(int startIndex, int endIndex, int stop)
        {
            if (startIndex > endIndex)
            {
                return -1;
            }
            if (startIndex == endIndex)
            {
                if (_trips[startIndex][0] >= stop)
                {
                    return startIndex;
                }
                else
                {
                    return -1;
                }
            }
            var mid = startIndex + ((endIndex - startIndex) >> 1);
            var trip = _trips[mid];

            //Case 1 : When current trip is less than stop
            if (trip[0] < stop)
            {
                return FindNextTrip(mid + 1, endIndex, stop);
            }
            //Case 2 : When current trip is greater or equal than stop
            else
            {
                return FindNextTrip(startIndex, mid, stop);
            }
        }
    }

    public class TripComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[0].CompareTo(y[0]);
        }
    }
}
