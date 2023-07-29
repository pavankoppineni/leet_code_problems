using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_306_AdditiveNumber_V1Tests
    {
        [TestMethod]
        public void Given_NumberString_When_CalculateForAdditiveNumber_Then_ShouldReturnTrueIfNumberIsAdditive()
        {
            //Given
            var number = "10101";
            var problem = new Leetcode_306_AdditiveNumber_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.IsAdditiveNumber(number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
