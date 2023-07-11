using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2305_FairDistributionOfCookies_V1Tests
    {
        [TestMethod]
        public void Given_CookiesAndChildren_When_CalculateFairDistribution_Then_ShouldReturnFairDistribution()
        {
            //Given
            var cookies = new int[] { 6, 1, 3, 2, 2, 4, 1, 2 };
            var childrenCount = 3;
            var problem = new Leetcode_2305_FairDistributionOfCookies_V1();
            var actualResult = 7;

            //When
            var expectedResult = problem.CalculateFairDistribution(cookies, childrenCount);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
