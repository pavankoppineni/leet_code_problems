using LeetCodeProblems.ArrayProblems.Leetcode_2364_CountNumberOfBadPairs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2364_CountNumberOfBadPairs
{
    [TestClass]
    public class Leetcode_2364_CountNumberOfBadPairs_V1Tests
    {
        [TestMethod]
        public void Given_IntegerValues_When_CalculateNumberOfBadPairs_Then_ShouldReturnNumberOfBadPairs()
        {
            //Given
            var values = new int[] { 4, 1, 3, 3 };
            var problem = new Leetcode_2364_CountNumberOfBadPairs_V1();
            var expectedResult = 5;

            //When
            var actualResult = problem.CalculateNumberOfBadPairs(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
