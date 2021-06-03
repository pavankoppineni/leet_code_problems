using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_268_MissingNumber_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMissingPositiveNumber_Then_ShouldReturnMissingPositiveNumber()
        {
            //Given
            var values = new int[] { 2, 3, 4, 0 };
            var problem = new Leetcode_268_MissingNumber_V1();
            var expectedMissingPositiveNumber = 1;

            //When
            var actualMissingPositiveNumber = problem.FindMissingNumber(values);

            //Then
            Assert.AreEqual(expectedMissingPositiveNumber, actualMissingPositiveNumber);
        }
    }
}
