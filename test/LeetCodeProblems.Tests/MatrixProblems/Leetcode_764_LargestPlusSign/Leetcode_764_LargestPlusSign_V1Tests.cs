using LeetCodeProblems.MatrixProblems.Leetcode_764_LargestPlusSign;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_764_LargestPlusSign
{
    [TestClass]
    public class Leetcode_764_LargestPlusSign_V1Tests
    {
        [TestMethod]
        public void Given_BinaryMatrixAndMines_When_CalculateOrder_Then_ShouldReturnOrderOfPlusSign()
        {
            //Given
            var rank = 5;
            var mines = new int[1][]
            {
                new int[] { 4, 2 }
            };
            var problem = new Leetcode_764_LargestPlusSign_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateOrderOfPlusSign(rank, mines);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
