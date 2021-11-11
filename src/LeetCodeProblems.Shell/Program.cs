using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml;
using LeetCodeProblems.DynamicProgramming.GFG_SubsetSum;

namespace LeetCodeProblems.Shell
{
    class Program
    {
        public static void Main()
        {
            var problem = new GFG_SubsetSum_V1();
            problem.FindSubsetSum(new int[]{3, 4, 5, 2}, 6);
        }
    }
}
