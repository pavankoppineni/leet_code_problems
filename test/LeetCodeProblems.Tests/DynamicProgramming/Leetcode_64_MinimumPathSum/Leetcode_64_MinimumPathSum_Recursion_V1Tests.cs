using LeetCodeProblems.DynamicProgramming.Leetcode_64_MinimumPathSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_64_MinimumPathSum
{
    [TestClass]
    public class Leetcode_64_MinimumPathSum_Recursion_V1Tests
    {
        [TestMethod]
        public void Given_Maze_When_FindMinimumPathSum_Then_ShouldReturnMinimumPathSum()
        {
            //Given
            var maze = new int[3][]
            {
                new int[]{1},
                new int[]{1},
                new int[]{1},
            };
            var problem = new Leetcode_64_MinimumPathSum_Recursion_V1();

            //When
            var actualResult = problem.FindMinimumPathSum(maze);

            //Then
            Assert.Inconclusive();
        }
    }
}
