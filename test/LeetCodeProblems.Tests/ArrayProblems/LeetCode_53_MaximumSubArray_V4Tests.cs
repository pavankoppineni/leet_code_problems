using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class LeetCode_53_MaximumSubArray_V4Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMaximumSubArraySum_Then_ShouldReturnMaxSubArraySum()
        {
            //Given
            var values = new int[] { 7, -6, -2, 9, 1 };
            var problem = new LeetCode_53_MaximumSubArray_V4();
            var expectedResult = 10;

            //When
            var actualResult = problem.FindMaxSubArray(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
