using LeetCodeProblems.ArrayProblems.Leetcode_525_ContiguousArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_525_ContiguousArray
{
    [TestClass]
    public class Leetcode_525_ContiguousArray_V1Tests
    {
        [TestMethod]
        public void Given_BinaryArray_When_CalculateMaxSubArray_Then_ShouldReturnSubArrayLength()
        {
            //Given
            var binaryArray = new int[] { 0, 1, 1 };
            var problem = new Leetcode_525_ContiguousArray_V1();
            var expectedLength = 2;

            //When
            var actualLength = problem.CalculateMaximumLength(binaryArray);

            //Then
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
