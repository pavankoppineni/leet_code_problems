using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_797_AllPathsFromSourceToTarget_V1Tests
    {
        [TestMethod]
        public void Given_Graph_When_GenerateAllPaths_Then_ShouldReturnAllPaths()
        {
            //Given
            var graph = new int[4][]
            {
                new int[]{1,2},
                new int[]{3},
                new int[]{3},
                new int[]{}
            };
            var problem = new Leetcode_797_AllPathsFromSourceToTarget_V1();
            var expectedResult = new int[2][]
            {
                new int[]{0,1,3},
                new int[]{0,2,3}
            };

            //When
            var actualResult = problem.GenerateAllPaths(graph);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Count);
        }
    }
}
