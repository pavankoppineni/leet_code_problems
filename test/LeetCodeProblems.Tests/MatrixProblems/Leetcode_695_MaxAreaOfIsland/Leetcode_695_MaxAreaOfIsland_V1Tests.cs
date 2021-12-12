using LeetCodeProblems.MatrixProblems.Leetcode_695_MaxAreaOfIsland;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_695_MaxAreaOfIsland
{
    [TestClass]
    public class Leetcode_695_MaxAreaOfIsland_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_FindMaxIslandArea_Then_ShouldReturnMaxAreaIsland()
        {
            //Given
            var matrix = new int[4][]
            {
                new int[]{1, 0, 0, 1 },
                new int[]{1, 0, 0, 1 },
                new int[]{1, 1, 1, 0 },
                new int[]{1, 1, 1, 0 }
            };
            var expectedIslandCount = 8;
            var problem = new Leetcode_695_MaxAreaOfIsland_V1();

            //When
            var actualIslandCount = problem.MaxAreaOfIsland(matrix);

            //Then
            Assert.AreEqual(expectedIslandCount, actualIslandCount);
        }
    }
}
