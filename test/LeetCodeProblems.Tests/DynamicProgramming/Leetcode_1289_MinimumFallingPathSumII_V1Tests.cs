using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_1289_MinimumFallingPathSumII_V1Tests
    {
        [TestMethod]
        public void Test()
        {
            //Given
            //[[],[],[],[],[]]
            var grid = new int[][]
            {
                new int[]{ -37,51,-36,34,-22},
                new int[]{ 82,4,30,14,38},
                new int[]{ -68,-52,-92,65,-85},
                new int[]{ -49, -3, -77, 8, -19 },
                new int[]{ -60, -71, -21, -62, -73 }
            };
            //var grid = new int[][]
            //{
            //    new int[]{  7}
            //};
            var expectedResult = 3;
            var problem = new Leetcode_1289_MinimumFallingPathSumII_V1();

            //When
            var actualResult = problem.CalculateMinimumFallingPath(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
