using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2929_DistributeCandiesAmongChildren_II_V1Tests
    {
        [TestMethod]    
        public void Given_CandiesAndLimit_When_CalculateWays_Then_ShouldReturnWays()
        {
            //Given
            var numberOfCandies = 10003;
            var limit = 20010;
            var problem = new Leetcode_2929_DistributeCandiesAmongChildren_II_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateNumberOfWays(numberOfCandies, limit);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
