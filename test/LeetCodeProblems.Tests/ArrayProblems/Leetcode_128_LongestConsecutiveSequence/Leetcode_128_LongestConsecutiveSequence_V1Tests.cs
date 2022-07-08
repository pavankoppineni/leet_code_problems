using LeetCodeProblems.ArrayProblems.Leetcode_128_LongestConsecutiveSequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_128_LongestConsecutiveSequence
{
    [TestClass]
    public class Leetcode_128_LongestConsecutiveSequence_V1Tests
    {
        [TestMethod]
        public void Given_IntegerValues_When_CalculateLongestConsecutiveSequence_Then_ShouldReturnMaxSequence()
        {
            //Given
            var values = new int[] { 100, 4, 200, 1, 3, 2 };
            var problem = new Leetcode_128_LongestConsecutiveSequence_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateLongestSequence(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
