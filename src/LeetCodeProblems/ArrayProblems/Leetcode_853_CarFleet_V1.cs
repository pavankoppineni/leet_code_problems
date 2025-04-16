using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/car-fleet/description
    /// </summary>
    public class Leetcode_853_CarFleet_V1
    {
        public int CalculateCarFleet(int target, int[] positions, int[] speed)
        {
            var fleet = CreateCarFleet(positions, speed, target);
            Array.Sort(fleet, new Car853());
            var previous = fleet[0];
            var count = 1;
            for (var index = 1; index < positions.Length; index++)
            {
                var current = fleet[index];
                if (current.Time <= previous.Time)
                {
                    continue;
                }
                count++;
                previous = current;
            }
            
            return count;
        }

        private static Car853[] CreateCarFleet(int[] positions, int[] speed, int target)
        {
            var fleet = new Car853[positions.Length];
            for (var index = 0; index < positions.Length; index++)
            {
                var remainingDistance = target - positions[index];
                double remainingTime = remainingDistance / (double)speed[index];
                fleet[index] = new Car853()
                {
                    Position = positions[index],
                    Speed = speed[index],
                    Time = remainingTime
                };
            }
            return fleet;
        }
    }

    public class Car853 : IComparer<Car853>
    {
        public int Position { get; set; }
        public int Speed { get; set; }
        public double Time {  get; set; }

        public int Compare(Car853 x, Car853 y)
        {
            return y.Position.CompareTo(x.Position);
        }
    }
}
