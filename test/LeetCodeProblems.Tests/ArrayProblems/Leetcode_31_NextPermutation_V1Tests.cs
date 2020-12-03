using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_31_NextPermutation_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindNextPermutation_Then_ShouldReturnNextPermutation()
        {
            //Given
            var nums = new int[] { 2, 3, 1 };
            var problem = new Leetcode_31_NextPermutation_V1();
            var expectedNums = new int[] { 3, 1, 2 };

            //When
            var actualNums = problem.FindNextPermutation(nums);

            //Then
            for (var i = 0; i < expectedNums.Length; i++)
            {
                Assert.AreEqual(expectedNums[i], actualNums[i]);
            }
        }
    }
}
