using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2428_MaximumSumOfHourglass_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_CalculateMaximumHourGlass_Then_ShouldReturnMaximumHourGlass()
        {
            //Given
            var problem = new Leetcode_2428_MaximumSumOfHourglass_V1();
            var grid = new int[4][]
            {
                new int[4]{ 6, 2, 1, 3},
                new int[4]{ 4, 2, 1, 5},
                new int[4]{ 9, 2, 8, 7 },
                new int[4]{ 4, 1, 2, 9 }
            };
            var expectedResult = 30;

            //When
            var actualResult = problem.CalculateMaximumSum(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
