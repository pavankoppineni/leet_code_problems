using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_215_KthLargestElementInAnArray_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindKthLargestElement_Then_ShouldReturnKthLargestElement()
        {
            //Given
            var nums = new int[] { 3,2,1,5,6,4 };
            var k = 2;
            var problem = new Leetcode_215_KthLargestElementInAnArray_V1();
            var expectedResult = 5;

            //When
            var actualResult = problem.FindKthLargestElement(nums, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
}
    }
}
