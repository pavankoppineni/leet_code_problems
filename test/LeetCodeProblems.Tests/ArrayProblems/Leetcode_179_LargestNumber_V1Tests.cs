using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_179_LargestNumber_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindLargestNumber_Then_ShouldReturnLargestNumber()
        {
            //Given
            var values = new int[] { 3, 30, 34, 5, 9 };
            var expectedResult = "9534330";
            var problem = new Leetcode_179_LargestNumber_V1();

            //When
            var actualResult = problem.FindLargestNumber(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
