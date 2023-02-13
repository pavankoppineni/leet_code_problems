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
            
        }
    }

    public class Tracer : IDisposable
    {
        private string _name;
        private static Tracer _current;
        private Tracer _parent;
        public Tracer(Tracer parent, string name)
        {
            _name = name;
            _parent = parent;
            _current = this;
        }

        public Tracer(string name)
        {
            _name = name;
            _parent = _current;
            _current = this;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Dispose()
        {
            _current = _parent;
        }
    }
}
