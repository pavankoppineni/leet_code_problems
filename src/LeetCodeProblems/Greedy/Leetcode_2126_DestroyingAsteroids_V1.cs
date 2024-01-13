using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/destroying-asteroids/
    /// </summary>
    public class Leetcode_2126_DestroyingAsteroids_V1
    {
        public bool AsteroidsDestroyed(int mass, int[] asteroids)
        {
            Array.Sort(asteroids);
            var destroyed = true;
            long longMass = mass;
            for (var index = 0; index < asteroids.Length; index++)
            {
                if (longMass >= asteroids[index])
                {
                    longMass += asteroids[index];
                }
                else
                {
                    destroyed = false;
                    break;
                }
            }
            return destroyed;
        }
    }
}
