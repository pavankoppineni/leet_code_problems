using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_565_ArrayNesting_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_ArrayNesting_Then_ShouldReturnLongestSubSetOfArrayNesting()
        {
            //Given
            var values = new int[] { 5, 4, 0, 3, 1, 6, 2 };
            var problem = new Leetcode_565_ArrayNesting_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.ArrayNesting(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
