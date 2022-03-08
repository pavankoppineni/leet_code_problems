using LeetCodeProblems.DynamicProgramming.Leetcode_191_NumberOfOneBits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_191_NumberOfOneBits
{
    [TestClass]
    public class Leetcode_191_NumberOfOneBits_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_CalculateHammingWeight_Then_ShouldReturnNumberOfSetBits()
        {
            //Given
            uint number = 8;
            var problem = new Leetcode_191_NumberOfOneBits_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateHammingWeight(number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
