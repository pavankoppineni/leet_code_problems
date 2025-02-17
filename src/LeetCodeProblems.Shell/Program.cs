using LeetCodeProblems.ArrayProblems;
using LeetCodeProblems.BinarySearchProblems;
using LeetCodeProblems.TwoPointers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Web;

namespace LeetCodeProblems.Shell
{
    public class Program
    {
        static IList<IDictionary<string, string>> lookuptables;
        public static void Main()
        {
            var values = new int[] { 3,1,2 };
            var values1 = new int[] { 8,5,8 };
            var success = 16;
            var problem = new Leetcode_2300_SuccessfulPairsOfSpellsAndPortions_V1();
            var resulst = problem.CalculateSuccessfulePairs(values, values1, success);
        }
    }
}
