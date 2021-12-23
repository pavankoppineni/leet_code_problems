using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.MinimumCostOfTravel
{
    public class MinimumCostOfTrainTravel_V1
    {
        public int FindMinimumCostOfTravel(int[][] costs)
        {
            return FindMinimumCostOfTravel(0, costs.Length - 1, costs);
        }

        private int FindMinimumCostOfTravel(int source, int destination, int[][] costs)
        {
            if (source == destination)
            {
                return 0;
            }

            if (source == destination - 1)
            {
                return costs[source][destination];
            }

            var minCost = costs[source][destination];
            for (var station = source + 1; station < destination; station++)
            {
                var cost = FindMinimumCostOfTravel(source, station, costs) 
                    + FindMinimumCostOfTravel(station, destination, costs);
                if (cost < minCost)
                {
                    minCost = cost;
                }
            }

            return minCost;
        }
    }
}
