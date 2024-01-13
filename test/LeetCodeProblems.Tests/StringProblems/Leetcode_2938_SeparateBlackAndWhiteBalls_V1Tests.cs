using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_2938_SeparateBlackAndWhiteBalls_V1Tests
    {
        [TestMethod]
        public void Given_BinaryString_When_CalculateMinimumSwaps_Then_ShouldReturnMinimumSteps()
        {
            //Given
            var binaryString = "001010";
            var problem = new Leetcode_2938_SeparateBlackAndWhiteBalls_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateMinumumNumberOfMoves(binaryString);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
