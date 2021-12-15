using LeetCodeProblems.DynamicProgramming.Leetcode_746_MinCostClimbingStairs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_746_MinCostClimbingStairs
{
    [TestClass]
    public class Leetcode_746_MinCostClimbingStairs_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMinCostOfClimbingStairs_Then_ShouldReturnMinConst()
        {
            //Given
            var costs = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            var problem = new Leetcode_746_MinCostClimbingStairs_V1();
            var expectedCost = 6;

            //When
            var actualCost = problem.MinCostClimbingStairs(costs);

            //Then
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
