using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2657_FindThePrefixCommonArrayOfTwoArrays_V1Tests
    {
        [TestMethod]
        public void Given_TwoArrays_When_ConstructPrefixCommonArray_Then_ShouldReturnPrefixCommonArray()
        {
            //Given
            var problem = new Leetcode_2657_FindThePrefixCommonArrayOfTwoArrays_V1();
            var arrayOne = new int[] { 1, 2, 3 };
            var arrayTwo = new int[] { 3, 2, 1 };
            var expectedResult = new int[] { 0, 1, 3 };

            //When
            var actualResult = problem.FindPrefixCommonArray(arrayOne, arrayTwo);

            //Then
            for(var index = 0; index < actualResult.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
