using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_135_Candy_V1Tests
    {
        [TestMethod]
        public void Given_Children_When_CalculateMinimumCandyCount_Then_ShouldReturnMinimumCandyCount()
        {
            //Given
            var children = new int[] { 1, 2, 2};
            var problem = new Leetcode_135_Candy_V1();
            var expectedResult = 6;

            //When
            var actualResult = problem.CalculateMinimumNumberOfCandies(children);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
