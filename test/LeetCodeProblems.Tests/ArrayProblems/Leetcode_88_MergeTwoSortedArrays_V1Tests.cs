using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_88_MergeTwoSortedArrays_V1Tests
    {
        [TestMethod]
        public void Given_TwoSortedArrays_When_Merge_Then_ShouldReturnSortedArray()
        {
            //Given
            var arrayOne = new int[] { 1, 2, 3 };
            var arrayTwo = new int[] { 2, 5, 6 };
            var problem = new Leetcode_88_MergeTwoSortedArrays_V1();
            var expectedResult = new int[] { 1, 2, 2, 3, 5, 6 };

            //When
            var actualResult = problem.Merge(arrayOne, arrayTwo);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Count);
        }
    }
}
