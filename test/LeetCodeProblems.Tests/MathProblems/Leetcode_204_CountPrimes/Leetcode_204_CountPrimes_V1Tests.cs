using LeetCodeProblems.MathProblems;
using LeetCodeProblems.MathProblems.Leetcode_204_CountPrimes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MathProblems.Leetcode_204_CountPrimes
{
    [TestClass]
    public class Leetcode_204_CountPrimes_V1Tests
    {
        [TestMethod]
        public void Given_Integer_When_CountPrimes_Then_ShouldReturnNumberOfPrimes()
        {
            //Given
            var n = 15;
            var problem = new Leetcode_204_CountPrimes_V1();
            var expectedResult = 6;

            //When
            var actualResult = problem.CountPrimes(n);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
