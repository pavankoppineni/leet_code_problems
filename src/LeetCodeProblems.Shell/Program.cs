using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using LeetCodeProblems.ArrayProblems;
using LeetCodeProblems.BinarySearchProblems;
using LeetCodeProblems.Greedy;
using LeetCodeProblems.MatrixProblems;
using LeetCodeProblems.SlidingWindowProblems;
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
using System.Text;
using System.Text.Json.Serialization;
using System.Web;

namespace LeetCodeProblems.Shell
{
    public class Program
    {
        public static void Main()
        {
            var problem = new Leetcode_2679_SumInMatrix_V1();
            var grid = new int[4][]
            {
                new int[] { 7, 2, 1 },
                new int[] { 6, 4, 2 },
                new int[] {6,5,3 },
                new int[]{3,2,1 }
            };

            var result = problem.CalculateSum(grid);
        }
    }
}
