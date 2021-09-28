using LeetCodeProblems.RecursionProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.RecursionProblems
{
    [TestClass]
    public class Leetcode_50_FindPowerOfNumber_V1Tests
    {
        private static IEnumerable<object[]> GetDatasetForTest()
        {
            //Case One 
            var testCaseOne = new object[]
            {
                2, 
                4, 
                16
            };
            var tests = new List<object[]> { testCaseOne };
            return tests;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDatasetForTest), DynamicDataSourceType.Method)]
        public void Given_BaseAndExponent_When_CalculatePower_Then_ShouldReturnPowerOfExponent(int baseNumber, int exponent, int expectedResult)
        {
            //Given
            var problem = new Leetcode_50_FindPowerOfNumber_V1();

            //When
            var actualResul = problem.FindPower(baseNumber, exponent);

            //Then
            Assert.AreEqual(expectedResult, actualResul);
        }
    }
}
