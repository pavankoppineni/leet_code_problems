using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/matchsticks-to-square/
    /// </summary>
    public class Leetcode_473_MatchsticksToSquare_V1
    {
        public bool CanSquareBeFormed(int[] matchSticks)
        {
            var sum = matchSticks.Sum();
            if (sum % 4 > 0)
            {
                return false;
            }
            var length = sum / 4;
            if (matchSticks.Any(x => x > length))
            {
                return false;
            }
            var sides = new int[4];
            return CanSquareBeFormed(matchSticks, 0, sides, length);
        }



        private bool CanSquareBeFormed(int[] matchSticks, int index, int[] sides, int sideLength)
        {
            if (index >= matchSticks.Length)
            {
                return sides.All(side => side == sideLength);
            }

            var result = false;
            for (var sideIndex = 0; sideIndex < sides.Length; sideIndex++)
            {
                if (sides[sideIndex] + matchSticks[index] > sideLength)
                {
                    continue;
                }
                sides[sideIndex] += matchSticks[index];
                result = CanSquareBeFormed(matchSticks, index + 1, sides, sideLength);
                if (result)
                {
                    break;
                }
                sides[sideIndex] -= matchSticks[index];
            }
            return result;
        }
    }
}
