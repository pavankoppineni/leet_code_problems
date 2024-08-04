using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/taking-maximum-energy-from-the-mystic-dungeon/
    /// </summary>
    public class Leetcode_3147_TakingMaximumEnergyFromMysticDungeon_V1
    {
        public int CalculateMaxEnergy(int[] energy, int k)
        {
            for (var index = 0; index < energy.Length; index++)
            {
                if (index - k < 0)
                {
                    continue;
                }
                energy[index] = Math.Max(energy[index - k] + energy[index], energy[index]);
            }

            var lastIndex = energy.Length - 1;
            var maxEnergy = energy[lastIndex];
            for (var index = 0; index < k; index++)
            {
                maxEnergy = Math.Max(maxEnergy, energy[lastIndex - index]);
            }
            return maxEnergy;
        }
    }
}
