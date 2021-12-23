using LeetCodeProblems.DynamicProgramming.MinimumCostOfTravel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.MinimumCostOfTrainTravel
{
    [TestClass]
    public class MinimumCostOfTrainTravel_V1Tests
    {
        [TestMethod]
        public void Given_CostsArray_When_FindMinimumCostOfTrainTravel_Then_ShouldReturnMinCostOfTravel()
        {
            //Given
            int[][] costs = new int[4][]
            {
                new int[]{0, 10, 75, 94 },
                new int[]{-1, 0, 35, 50 },
                new int[]{-1, -1, 0, 80 },
                new int[]{-1, -1, -1, 0 }
            };
            var problem = new MinimumCostOfTrainTravel_V1();
            var expectedCost = 2;
            //When
            var actualCost = problem.FindMinimumCostOfTravel(costs);

            //Then
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
