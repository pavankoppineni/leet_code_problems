using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_41_FindMissingPositive_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMissingPositive_Then_ShouldReturnFirstMissingPositive()
        {
            //Given
            var values = new int[] { -1, 0, 1, 2, 3 };
            var problem = new Leetcode_41_FindMissingPositive_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.FindMissingPositive(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
