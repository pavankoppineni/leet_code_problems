using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1010_PairsOfSongsWithTotalDurationsDivisibleBy60_V1Tests
    {
        [TestMethod]
        public void Given_SongDurations_When_CalculateNumberOfPairs_Then_ShouldReturnNumberOfPairs()
        {
            //Given
            var values = new int[] { 30, 60, 60 };
            var problem = new Leetcode_1010_PairsOfSongsWithTotalDurationsDivisibleBy60_V1();
            var expectedValue = 1;

            //When
            var actualValue = problem.CalculateNumberOfPairs(values);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
