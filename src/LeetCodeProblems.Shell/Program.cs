using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml;
using LeetCodeProblems.StringProblems;

namespace LeetCodeProblems.Shell
{
    class Program
    {
        public static void Main()
        {
            var problem = new Leetcode_856_ScoreOfParatheses_V2();
            var score = problem.CalculateScore("{}{}");
        }
    }
}
