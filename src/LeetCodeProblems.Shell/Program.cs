using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using LeetCodeProblems.DynamicProgramming.Leetcode_1231_DivideChocolates;
using LeetCodeProblems.Shell.LoadBalancer;
using LeetCodeProblems.Shell.RequestResponseAsync;
using LeetCodeProblems.StringProblems;

namespace LeetCodeProblems.Shell
{
    public class Program
    {
        public static void Main()
        {
            var inProgress = new List<string>();
            var compPortalsSet = new HashSet<string>();
            var compPortals = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\leet_code_problems\src\LeetCodeProblems.Shell\Files\migrated-portals.txt");
            var livePortals = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\leet_code_problems\src\LeetCodeProblems.Shell\Files\live-portals.txt");
            foreach (var livePortal in livePortals)
            {
                compPortalsSet.Add(livePortal.ToUpper());
            }
            foreach(var compPortal in compPortals)
            {
                if (compPortalsSet.Contains(compPortal.ToUpper()))
                {
                    inProgress.Add(compPortal.ToUpper());
                }
            }
            var a = String.Join("\n", inProgress);
        }
    }
}
