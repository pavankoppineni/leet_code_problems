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
            var dict = new HashSet<Tuple<int, int>>();
            dict.Add(new Tuple<int, int>(1, 2));
            dict.Add(new Tuple<int, int>(1, 2));
            dict.Add(new Tuple<int, int>(2, 1));
        }
    }
}
