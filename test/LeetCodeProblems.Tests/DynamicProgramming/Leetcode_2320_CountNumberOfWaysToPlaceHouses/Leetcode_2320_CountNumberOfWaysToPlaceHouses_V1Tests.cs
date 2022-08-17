using LeetCodeProblems.DynamicProgramming.Leetcode_2320_CountNumberOfWaysToPlaceHouses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_2320_CountNumberOfWaysToPlaceHouses
{
    [TestClass]
    public class Leetcode_2320_CountNumberOfWaysToPlaceHouses_V1Tests
    {
        [TestMethod]
        public void Given_NumberOfPlots_When_CalculateNumberOfPlacements_Then_ShouldReturnNumberOfPlacements()
        {
            //Given
            var number = 3;
            var problem = new Leetcode_2320_CountNumberOfWaysToPlaceHouses_V1();
            var expectedResult = 64;

            //When
            var actualResult = problem.CalculateNumberOfPlacements(number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
