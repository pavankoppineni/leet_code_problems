using LeetCodeProblems.ArrayProblems.Leetcode_2256_MinimumAverageDifference;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2256_MinimumAverageDifference
{
    [TestClass]
    public class Leetcode_2256_MinimumAverageDifference_V1Tests
    {
        [TestMethod]
        public void Given_Values_When_CalculateMinimumAverageDifference_Then_ShouldMinimumAverageDifferenceIndex()
        {
            //Given
            var values = new int[] { 2, 5, 3, 9, 5, 3 };
            var problem = new Leetcode_2256_MinimumAverageDifference_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateMinimumAverageDifference(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
