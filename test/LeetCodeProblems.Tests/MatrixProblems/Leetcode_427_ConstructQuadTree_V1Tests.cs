using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_427_ConstructQuadTree_V1Tests
    {
        [TestMethod]
        public void Given_BinaryGrid_When_ConstructQuadTree_Then_ShouldReturnQuadTree()
        {
            //Given
            var grid = new int[4][];
            grid[0] = new int[4] { 0, 0, 0, 0 };
            grid[1] = new int[4] { 0, 0, 0, 0 };
            grid[2] = new int[4] { 1, 1, 1, 1 };
            grid[3] = new int[4] { 1, 1, 1, 1, };
            var problem = new Leetcode_427_ConstructQuadTree_V1();

            //When
            var actualNode = problem.ConstructQuadTree(grid);

            //Then
            Assert.IsNotNull(actualNode);
        }
    }
}
