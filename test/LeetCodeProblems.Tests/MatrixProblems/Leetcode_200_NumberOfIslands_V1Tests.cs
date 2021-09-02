using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_200_NumberOfIslands_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_FindNumberOfIslands_Then_ShouldReturnNumberOfIslands()
        {
            //Given
            var matrix = new int[4, 4]
            {
                {1, 0, 0, 1 },
                {1, 0, 0, 1 },
                {1, 1, 1, 0 },
                {1, 1, 1, 0 }
            };
            var expectedIslandCount = 2;
            var problem = new Leetcode_200_NumberOfIslands_V1();

            //When
            var actualIslandCount = problem.FindNumberOfIslands(matrix);

            //Then
            Assert.AreEqual(expectedIslandCount, actualIslandCount);
        }
    }
}
