using LeetCodeProblems.SlidingWindowProblems.Leetcode_413_ArithmeticSlices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.SlidingWindowProblems.Leetcode_413_ArithmeticSlices
{
    [TestClass]
    public class Leetcode_413_ArithmeticSlices_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfNumbers_When_CalculateNumberOfArithmeticSlices_Then_ShouldReturnNumberOfArithmeticSlices()
        {
            //Given
            var values = new int[] { 1, 3, 5, 7 };
            var problem = new Leetcode_413_ArithmeticSlices_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalaculateNumberOfArithmeticSlices(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
