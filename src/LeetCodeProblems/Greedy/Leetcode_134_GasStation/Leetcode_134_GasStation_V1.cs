using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_134_GasStation
{
    /// <summary>
    /// https://leetcode.com/problems/gas-station/
    /// </summary>
    public class Leetcode_134_GasStation_V1
    {
        public int CalculateGasStation(int[] gas, int[] costs)
        {
            if(gas.Length == 1)
            {
                if(gas[0] >= costs[0])
                {
                    return 0;
                }
                return -1;
            }
            gas[0] = gas[0] - costs[0];
            var previous = gas[0] > 0 ? gas[0] : 0;
            var gasStation = gas[0] > 0 ? 0 : -1;
            for (var index = 1; index < gas.Length; index++)
            {
                var diff = gas[index] - costs[index];
                previous += diff;
                if (previous < 0)
                {
                    gasStation = -1;
                    previous = 0;
                }
                else
                {
                    if (gasStation == -1)
                    {
                        gasStation = index;
                    }
                }
                gas[index] = diff + gas[index - 1];
            }
            if (gasStation == -1)
            {
                return gasStation;
            }
            if (gasStation == 0)
            {
                if (gas[gas.Length - 1] > 0)
                {
                    return gasStation;
                }
                return -1;
            }
            var left = gas[gasStation - 1];
            var right = gas[gas.Length - 1] - left;
            if (right >= -1 * left)
            {
                return gasStation;
            }
            return -1;
        }
    }
}
