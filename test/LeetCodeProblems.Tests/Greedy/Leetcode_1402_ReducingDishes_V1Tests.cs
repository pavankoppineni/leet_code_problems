using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_1402_ReducingDishes_V1Tests
    {
        [TestMethod]
        public void Given_DishesWithSatisfactions_When_CalculateMaximumSatisfactions_Then_ShouldReturnMaximumSatisfaction()
        {
            //Given
            var satisfactions = new int[] { 0, 5, -1, -8, -9 };
            var problem = new Leetcode_1402_ReducingDishes_V1();
            var expectedResult = 14;

            //When
            var actualResult = problem.CalculateMaximumSatisfaction(satisfactions);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
