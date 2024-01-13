using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/separate-black-and-white-balls/
    /// </summary>
    public class Leetcode_2938_SeparateBlackAndWhiteBalls_V1
    {
        public long CalculateMinumumNumberOfMoves(string binaryString)
        {
            var zeroCount = 0;
            var moves = 0;
            var index = 0;
            while (index < binaryString.Length)
            {
                if (binaryString[index] == '0')
                {
                    zeroCount += 1;
                    moves += index - zeroCount + 1;
                }
                index++;
            }
            return moves;
        }
    }
}
