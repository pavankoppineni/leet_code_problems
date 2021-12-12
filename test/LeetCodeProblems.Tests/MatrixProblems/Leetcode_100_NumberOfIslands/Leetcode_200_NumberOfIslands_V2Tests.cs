using LeetCodeProblems.MatrixProblems.Leetcode_100_NumberOfIslands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_100_NumberOfIslands
{
    [TestClass]
    public class Leetcode_200_NumberOfIslands_V2Tests
    {
        [TestMethod]
        public void Given_Matrix_When_FindNumberOfIslands_Then_ShouldReturnNumberOfIslands()
        {
            //Given
            var matrix = new int[4][]
            {
                new int[]{1, 0, 0, 1 },
                new int[]{1, 0, 0, 1 },
                new int[]{1, 1, 1, 0 },
                new int[]{1, 1, 1, 0 }
            };
            var expectedIslandCount = 2;
            var problem = new Leetcode_200_NumberOfIslands_V2();

            //When
            var actualIslandCount = problem.FindNumberOfIslands(matrix);

            //Then
            Assert.AreEqual(expectedIslandCount, actualIslandCount);
        }
    }
}
