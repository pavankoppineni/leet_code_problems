using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2466_CountWaysToBuildGoodStrings_V1Tests
    {
        [TestMethod]
        public void Given_LowAndHigh_When_CountBuildGoodStrings_Then_ShouldReturnCountOfGoodStrings()
        {
            //Given
            var zeroCount = 1;
            var oneCount = 2;
            var low = 2;
            var high = 3;
            var problem = new Leetcode_2466_CountWaysToBuildGoodStrings_V1();
            var expectedResult = 5;

            //When
            var actualResult = problem.CountGoodStrings(low, high, zeroCount, oneCount);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
