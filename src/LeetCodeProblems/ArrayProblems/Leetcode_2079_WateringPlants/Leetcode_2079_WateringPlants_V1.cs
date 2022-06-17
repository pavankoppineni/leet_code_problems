using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2079_WateringPlants
{
    /// <summary>
    /// https://leetcode.com/problems/watering-plants/
    /// </summary>
    public class Leetcode_2079_WateringPlants_V1
    {
        public int CalculateSteps(int[] plants, int capacity)
        {
            var actualCapacity = capacity;
            var steps = 0;
            for (var index = 0; index < plants.Length; index++)
            {
                var plant = plants[index];

                //Case 1 : When plant is greater than capacity
                if (plant > capacity)
                {
                    capacity = actualCapacity;
                    steps += index;
                    steps += index + 1;
                    capacity -= plant;
                }
                //Case 2 : When plant is less than capacity
                else
                {
                    steps++;
                    capacity -= plant;
                }

            }
            return steps;
        }
    }
}
