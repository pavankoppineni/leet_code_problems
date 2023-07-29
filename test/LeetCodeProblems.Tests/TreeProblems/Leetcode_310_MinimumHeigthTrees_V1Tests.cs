using LeetCodeProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_310_MinimumHeigthTrees_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_CalculateMinimumHeightTrees_Then_ShoulReturnMinimumHeightRoots()
        {
            //Given
            var nodes = 6;
            var edges = new int[5][]
            {
                new int[]{3,0},
                new int[]{3,1},
                new int[]{3,2},
                new int[]{3,4},
                new int[]{5,4}
            };
            var problem = new Leetcode_310_MinimumHeigthTrees_V1();
            var expectedResult = new int[] { 3, 4 };

            //When
            var actualResult = problem.CalculateMinimumHeightTreeRoots(nodes, edges);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Count);
        }
    }
}
