using LeetCodeProblems.DynamicProgramming.Leetcode_1937_MaximumNumberOfPointsWithCost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_1937_MaximumNumberOfPointsWithCost
{
    [TestClass]
    public class Leetcode_1937_MaximumNumberOfPointsWithCost_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_CalculateMaximumPoints_Then_ShouldReturnMaximumPoints()
        {
            //Given
            var points = new int[3][]
            {
                new int[]{2,4,0,5,5},
                new int[]{0,5,4,2,5},
                new int[]{ 2, 0, 2, 3, 1 }
            };
            var problem = new Leetcode_1937_MaximumNumberOfPointsWithCost_V1();
            var expectedResult = 9;

            //When
            var actualResult = problem.CalculateMaximumNumberOfPoints(points);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
