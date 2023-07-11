using LeetCodeProblems.GraphProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Graph_Problems
{
    [TestClass]
    public class Leetcode_2368_ReachableNodesWithRestrictions_V1Tests
    {
        [TestMethod]
        public void Given_NodesAndRestrictedNodes_When_CalculateReachableNodes_Then_ShouldReturnCountOfReachableNodes()
        {
            //Given
            var nodeCount = 7;
            var edges = new int[6][]
            {
                new int[]{0,1},
                new int[]{1,2},
                new int[]{3,1},
                new int[]{4,0},
                new int[]{0,5},
                new int[]{5,6}
            };
            var restrictedNodes = new int[] { 4, 5 };
            var expectedResult = 4;
            var problem = new Leetcode_2368_ReachableNodesWithRestrictions_V1();

            //When
            var actualResult = problem.CalculateReachablesNodes(nodeCount, edges, restrictedNodes);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
