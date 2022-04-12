using LeetCodeProblems.ArrayProblems.Leetcode_2016_MaximumDifferenceBetweenIncreasingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2016_MaximumDifferenceBetweenIncreasingElements
{
    [TestClass]
    public class Leetcode_2016_MaximumDifferenceBetweenIncreasingElements_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMaxDifference_Then_ShouldReturnMaxDifference()
        {
            //Given
            var nums = new int[] { 1, 2, 3, 4 };
            var problem = new Leetcode_2016_MaximumDifferenceBetweenIncreasingElements_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateMaximumDifference(nums);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
