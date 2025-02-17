using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-to-cut-a-stick/
    /// </summary>
    public class Leetcode_1547_MinimumCosttoCutaStick_V1
    {
        private int[] _cuts;
        public int CalculateMinimumCost(int n, int[] cuts)
        {
            return 0;
        }
    }

    public struct Range
    {
        public int Start { get; set; }
        public int End { get; set; }
    }

    public struct CutRange
    {
        public int Start { get; set; }
        public int End { get; set; }

        public static CutRange Create(int start, int end)
        {
            return new CutRange
            { 
                Start = start, 
                End = end 
            };
        }
    }
}
