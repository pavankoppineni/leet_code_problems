using LeetCodeProblems.Greedy.Leetcode_670_MaximumSwap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_670_MaximumSwap
{
    [TestClass]
    public class Leetcode_670_MaximumSwap_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_MaximumSwap_Then_ShouldReturnMaximumNumberAfterOneSwap()
        {
            //Given
            var num = 1993;
            var problem = new Leetcode_670_MaximumSwap_V1();
            var expectedResult = 9913;

            //When
            var actualResult = problem.MaximumSwap(num);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
