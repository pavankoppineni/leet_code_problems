using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_1011_CapacityToShipPackagesWithinDDays
{
    /// <summary>
    /// https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
    /// </summary>
    public class Leetcode_1011_CapacityToShipPackagesWithinDDays_V1
    {
        private int _days;
        private int[] _weigths;
        public int ShipWithinDays(int[] weights, int days)
        {
            _days = days;
            var totalWeigth = 0;
            var maxWigth = weights[0];
            _weigths = weights;
            foreach (var weight in weights)
            {
                totalWeigth += weight;
                if (weight > maxWigth)
                {
                    maxWigth = weight;
                }
            }
            var minWeight = FindDays(maxWigth, totalWeigth);
            return minWeight;
        }

        private int FindDays(int minWeight, int maxWeight)
        {
            if (minWeight == maxWeight)
            {
                return minWeight;
            }

            var midWeight = (maxWeight + minWeight) / 2;
            var daysCount = CalculateDays(midWeight);

            //Case 1 : daysCount is greater than _days
            if (daysCount > _days)
            {
                return FindDays(midWeight + 1, maxWeight);
            }
            //Case 2 : daysCount is less than _days
            return FindDays(minWeight, midWeight);
        }

        private int CalculateDays(int weight)
        { 
            var days = 0;
            var currentWeight = 0;
            foreach (var wt in _weigths)
            {
                if (currentWeight + wt > weight)
                {
                    days++;
                    currentWeight = wt;
                }
                else
                {
                    currentWeight += wt;
                }
            }
            return days + 1;
        }
    }
}
