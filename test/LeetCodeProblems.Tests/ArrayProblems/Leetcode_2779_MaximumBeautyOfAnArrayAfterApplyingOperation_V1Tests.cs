using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2779_MaximumBeautyOfAnArrayAfterApplyingOperation_V1Tests
    {
        [TestMethod]
        public void Given_IntegerValues_When_CalculateMaximumBeauty_Then_ShouldReturnMaximumBeatuy()
        {
            //Given
            var values = new int[] { 32, 16, 98 };
            var problem = new Leetcode_2779_MaximumBeautyOfAnArrayAfterApplyingOperation_V1();
            var expectedResult = 10;
            var k = 0;

            //When
            var actualResult = problem.CalculateMaximumBeauty(values, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
