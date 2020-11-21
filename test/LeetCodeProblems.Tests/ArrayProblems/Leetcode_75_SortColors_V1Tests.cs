using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_75_SortColors_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_SortColors_Then_ShouldReturnSortedArray()
        {
            //Given
            var values = new int[] { 1, 1, 0, 2, 2, 2 };
            var problem = new Leetcode_75_SortColors_V1();
            var expectedResult = new int[] { 0, 1, 1, 2, 2, 2 };

            //When
            var actualResult = problem.SortColors(values);

            //Then
            for (var i = 0; i < actualResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
