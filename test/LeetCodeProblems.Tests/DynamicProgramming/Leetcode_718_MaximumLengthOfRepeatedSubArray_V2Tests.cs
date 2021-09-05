using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_718_MaximumLengthOfRepeatedSubArray_V2Tests
    {
        [TestMethod]
        public void Given_TwoIntegerArrays_When_MaximumRepeatedSubArray_Then_ShouldReturnMaximumRepeatedSubArray()
        {
            //Given
            var arrayOne = new int[] { 1, 2, 3, 2, 1 };
            var arrayTwo = new int[] { 3, 2, 1, 4, 7 };
            var problem = new Leetcode_718_MaximumLengthOfRepeatedSubArray_V2();
            var expectedResult = 3;

            //When
            var actualResult = problem.FindMaximumLengthOfRepeatedSubArray(arrayOne, arrayTwo);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
