using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_718_MaximumLengthOfRepeatedSubArray_V1Tests
    {
        [TestMethod]
        public void Given_TwoArrays_When_FindMaximumLengthOfSubArray_Then_ShouldReturnMaximumLengthOfCommonSubArray()
        {
            //Given
            var arrayOne = new int[] { 1, 2, 3};
            var arrayTwo = new int[] { 3, 1, 2 };
            var problem = new Leetcode_718_MaximumLengthOfRepeatedSubArray_V1();
            var expectedValue = 2;

            //When
            var actualValue = problem.FindMaximumLengthOfSubArray(arrayOne, arrayTwo);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
