using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_1218_LongestArithmeticSubsequenceofGivenDifference_V1Tests
    {
        [TestMethod]
        public void Given_Sequence_When_CalculateLongestArithmeticSequence_Then_ShouldReturnMaxLength()
        {
            //Given
            var values = new int[] {1, 3, 5};
            var difference = 1;
            var problem = new Leetcode_1218_LongestArithmeticSubsequenceofGivenDifference_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateLongestAirthmeticSequence(values, difference);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
