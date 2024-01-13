using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_2684_MaximumNumberOfMovesInGrid_V1Tests
    {
        [TestMethod]
        public void Given_IntegerGrid_When_MaximumMoves_Then_ShouldReturnMaximumMoves()
        {
            //Given
            var grid = new int[4][]
            {
                 new int[] {2, 4, 3, 5 },
                 new int[] {5, 4, 9, 3 },
                 new int[] {3, 4, 2, 11 },
                 new int[] {10, 9, 13, 15}
            };
            var problem = new Leetcode_2684_MaximumNumberOfMovesInGrid_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateMaximumMoves(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
