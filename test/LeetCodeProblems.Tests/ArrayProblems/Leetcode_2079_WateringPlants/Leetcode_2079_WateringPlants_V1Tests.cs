using LeetCodeProblems.ArrayProblems.Leetcode_2079_WateringPlants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2079_WateringPlants
{
    [TestClass]
    public class Leetcode_2079_WateringPlants_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfPlantsAndCapacity_When_CalculateSteps_Then_ShouldCalculateSteps()
        {
            //Given
            var plants = new int[] { 3,2,4,2,1 };
            var capacity = 6;
            var problem = new Leetcode_2079_WateringPlants_V1();
            var expectedResult = 17;

            //When
            var actualResult = problem.CalculateSteps(plants, capacity);

            //Then
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
