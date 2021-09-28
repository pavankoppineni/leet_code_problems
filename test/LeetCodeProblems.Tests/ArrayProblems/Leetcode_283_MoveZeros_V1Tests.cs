using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_283_MoveZeros_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_MoveZeros_Then_ShouldMoveAllZerosToLast()
        {
            //Given
            var arr = new int[] { 1, 0, 3, 5, 0, 1 };
            var problem = new Leetcode_283_MoveZeros_V1();
            var expectedResult = new int[] { 1, 3, 5, 1, 0, 0};

            //When
            var actualResult = problem.MoveZeros(arr);

            //Then
            for (var index = 0; index < arr.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
