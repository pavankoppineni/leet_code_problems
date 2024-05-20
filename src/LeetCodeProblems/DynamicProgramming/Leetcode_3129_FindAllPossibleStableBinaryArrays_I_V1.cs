using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-possible-stable-binary-arrays-i/
    /// </summary>
    public class Leetcode_3129_FindAllPossibleStableBinaryArrays_I_V1
    {
        private int[] _prefixSum;
        private int _limit;
        public int CalculateNumberOfStableBinaryArrays(int zeroCount, int oneCount, int limit)
        {
            _limit = limit;
            _prefixSum = new int[zeroCount + oneCount];
            if (zeroCount == 0 && oneCount == 0)
            {
                return 0;
            }

            if (zeroCount == 0 || oneCount == 0)
            {
                return 1;
            }
            return -1;
        }

        private int Calculate(int zeroCount, int oneCount, int level)
        {
            //When : zeroCount or oneCount is zero
            //Then : return 1
            if (zeroCount == 0 || zeroCount == 0)
            {
                return 1;
            }

            var pairCount = new PairCount();
            var previousSum = level <= 0 ? 0 : _prefixSum[level - 1];

            var startIndex = level - _limit;
            // Decrement zeroCount
            _prefixSum[level] = previousSum;
            pairCount.Left = Calculate(zeroCount - 1, oneCount, level + 1);

            // Decrement oneCount
            _prefixSum[level] += 1;
            pairCount.Right = Calculate(zeroCount, oneCount - 1, level + 1);

            return pairCount.Total;
        }

        internal struct PairCount
        {
            internal int Left { get; set; }
            internal int Right { get; set; }
            internal int Total => Left + Right;
        }
    }
}
