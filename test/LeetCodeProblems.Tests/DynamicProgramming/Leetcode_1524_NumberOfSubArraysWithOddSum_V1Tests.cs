using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_1524_NumberOfSubArraysWithOddSum_V1Tests
    {
        [TestMethod]
        public void Given_IntegeArray_When_CalculateNumberOfSubArrays_Then_ShouldReturnNumberOfSubArrays()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var problem = new Leetcode_1524_NumberOfSubArraysWithOddSum_V1();
            var expectedResult = 28;

            //When
            var actualResult = problem.CalculateNumberOfSubArrays(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
