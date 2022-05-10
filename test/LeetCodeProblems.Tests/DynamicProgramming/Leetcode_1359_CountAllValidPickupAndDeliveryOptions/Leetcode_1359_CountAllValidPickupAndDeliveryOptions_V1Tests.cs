using LeetCodeProblems.DynamicProgramming.Leetcode_1359_CountAllValidPickupAndDeliveryOptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_1359_CountAllValidPickupAndDeliveryOptions
{
    [TestClass]
    public class Leetcode_1359_CountAllValidPickupAndDeliveryOptions_V1Tests
    {
        [TestMethod]
        public void Given_CountOfItems_When_CountWays_Then_ShouldReturnNumberOfWays()
        {
            //Given
            var count = 9;
            var problem = new Leetcode_1359_CountAllValidPickupAndDeliveryOptions_V1();
            var expectedResult = 9;

            //When
            var actualResult = problem.CalculateWays(count);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
