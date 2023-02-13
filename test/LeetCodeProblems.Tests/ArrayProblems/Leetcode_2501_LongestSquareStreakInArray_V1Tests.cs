using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2501_LongestSquareStreakInArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateLongestSquareStreak_Then_ShouldReturnLongestSquareStreak()
        {
            //Given
            var values = new int[] { 4, 3, 6, 16, 8, 2 };
            var problem = new Leetcode_2501_LongestSquareStreakInArray_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateLongestSquareStreak(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
