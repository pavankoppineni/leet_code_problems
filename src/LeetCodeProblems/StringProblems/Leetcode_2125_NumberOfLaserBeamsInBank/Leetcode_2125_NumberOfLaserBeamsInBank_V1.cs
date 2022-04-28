using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems.Leetcode_2125_NumberOfLaserBeamsInBank
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-laser-beams-in-a-bank/
    /// </summary>
    public class Leetcode_2125_NumberOfLaserBeamsInBank_V1
    {
        public int CalclulateLaserBeams(string[] bank)
        {
            if (bank.Length == 1)
            {
                return 0;
            }
            var numberOfBeans = 0;
            var previousCamerasCount = 0;
            for (var floor = 0; floor < bank.Length; floor++)
            {
                var camerasCount = 0;
                foreach (var room in bank[floor])
                {
                    if (room == '1')
                    {
                        camerasCount += 1;
                    }
                }
                numberOfBeans += previousCamerasCount * camerasCount;
                if (camerasCount > 0)
                {
                    previousCamerasCount = camerasCount;
                }
            }
            return numberOfBeans;
        }
    }
}
