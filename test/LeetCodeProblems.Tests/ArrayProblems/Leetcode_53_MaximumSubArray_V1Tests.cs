using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_53_MaximumSubArray_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMaximumSubArraySum_Then_ShouldReturnSubArrayWithMaxSum()
        {
            //Given
            var values = new int[] { -1, -2, -3, 4 };
            var problem = new Leetcode_53_MaximumSubArray_V1();
            var expectedMaxSum = 4;

            //When
            var actualMaxSum = problem.FindMaximumSum(values);

            //Then
            Assert.AreEqual(expectedMaxSum, actualMaxSum);
        }
    }
}
