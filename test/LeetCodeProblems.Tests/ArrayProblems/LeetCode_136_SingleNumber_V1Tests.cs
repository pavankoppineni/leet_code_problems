using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class LeetCode_136_SingleNumber_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindSingleNumber_Then_ShouldReturnSingleNumberFromArray()
        {
            //Given
            var values = new int[] { 2, 2, 1, 5, 5 };
            var singleNumberProblem = new Leetcode_136_SingleNumber_V1();
            var expectedResult = 1;

            //When
            var actualResult = singleNumberProblem.FindSingleNumber(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
