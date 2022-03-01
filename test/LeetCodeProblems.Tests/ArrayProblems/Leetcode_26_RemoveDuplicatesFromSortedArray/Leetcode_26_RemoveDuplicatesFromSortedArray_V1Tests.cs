using LeetCodeProblems.ArrayProblems.Leetcode_26_RemoveDuplicatesFromSortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_26_RemoveDuplicatesFromSortedArray
{
    [TestClass]
    public class Leetcode_26_RemoveDuplicatesFromSortedArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_RemoveDuplicates_Then_ShouldReturnNumberOfDistinctNumbers()
        {
            //Given
            var nums = new int[] { 1, 1, 2 };
            var problem = new Leetcode_26_RemoveDuplicatesFromSortedArray_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.RemoveDuplicates(nums);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
