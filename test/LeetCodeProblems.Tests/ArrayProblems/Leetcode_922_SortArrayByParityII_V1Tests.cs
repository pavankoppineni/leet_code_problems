using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_922_SortArrayByParityII_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_SortArrayByParity_Then_ShouldReturnArraySortedByParity()
        {
            //Given
            var values = new int[] { 4, 10, 16, 1, 3, 9 };
            var problem = new Leetcode_922_SortArrayByParityII_V1();
            var expectedResult = new int[] { 4, 1, 10, 3, 16, 9 };

            //When
            var actualResult = problem.SortyByParity(values);

            //Then
            for (var i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
