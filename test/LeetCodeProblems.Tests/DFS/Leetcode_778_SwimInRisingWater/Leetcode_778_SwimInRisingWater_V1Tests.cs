using LeetCodeProblems.DFS.Leetcode_778_SwimInRisingWater;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DFS.Leetcode_778_SwimInRisingWater
{
    [TestClass]
    public class Leetcode_778_SwimInRisingWater_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_CalculateSwim_Then_ShouldReturnMinimumSwim()
        {
            //Given
            var input = new int[2][]
            {
                new int[]{0,2},
                new int[]{1,3},
            };
            var problem = new Leetcode_778_SwimInRisingWater_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateSwimWater(input);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
