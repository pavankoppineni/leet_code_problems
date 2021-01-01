using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_905_SortArrayByParity_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_SortArrayByParity_Then_ShouldReturnArrayHavingEvenValuesToLeftAndOddValuesToRight()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var problem = new Leetcode_905_SortArrayByParity_V1();
            var expectedResult = new int[] { 8, 2, 6, 4, 5, 3, 7, 1, 9 };

            //When
            var actualResult = problem.SortyArrayByParity(values);

            //Then
            for (var i = 0; i < actualResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
