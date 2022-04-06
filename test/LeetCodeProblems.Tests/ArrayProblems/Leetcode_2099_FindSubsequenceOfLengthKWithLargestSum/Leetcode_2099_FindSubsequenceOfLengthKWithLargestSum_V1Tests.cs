using LeetCodeProblems.ArrayProblems.Leetcode_2099_FindSubsequenceOfLengthKWithLargestSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2099_FindSubsequenceOfLengthKWithLargestSum
{
    [TestClass]
    public class Leetcode_2099_FindSubsequenceOfLengthKWithLargestSum_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindLargestSum_Then_ShouldReturnSubSequence()
        {
            //Given
            var nums = new int[] { 7, -1, -4, 4, 3 };
            var k = 3;
            var problem = new Leetcode_2099_FindSubsequenceOfLengthKWithLargestSum_V1();
            var expecteRresult = new int[] { 7, 4, 3 };

            //When
            var actualResult = problem.MaxSubsequence(nums, k);

            //Then
            Assert.AreEqual(expecteRresult.Length, actualResult.Length);
        }
    }
}
