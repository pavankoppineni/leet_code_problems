using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2429_MinimizeXOR_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMinimumValue_Then_ShouldReturnMinimumValue()
        {
            //Given
            var problem = new Leetcode_2429_MinimizeXOR_V1();
            var numberOne = 25;
            var numberTwo = 72;
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateValue(numberOne, numberTwo);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
