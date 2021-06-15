using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.HackerEarthChallenges.Kongsberg
{
    /// <summary>
    /// https://www.geeksforgeeks.org/xor-of-a-subarray-range-of-elements/
    /// </summary>
    public class Kongsberg_Problem_One_V1
    {
        private int[] values;
        private int[,] xorValues;

        public void ProcessArray(int[] values)
        {
            this.values = values;
            xorValues = new int[values.Length, 32];
            this.ProcessXORArray();
        }

        private void ProcessXORArray()
        {
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                for (var i = 0; i < 4; i++)
                {
                    var currentBit = 1 << i;
                    var result = value & currentBit;
                    if (result > 0)
                    {
                        xorValues[index, i] += 1;
                    }
                }
            }
        }

        public int CalculateXOR(int left, int right)
        {
            return 1;
        }
    }
}
