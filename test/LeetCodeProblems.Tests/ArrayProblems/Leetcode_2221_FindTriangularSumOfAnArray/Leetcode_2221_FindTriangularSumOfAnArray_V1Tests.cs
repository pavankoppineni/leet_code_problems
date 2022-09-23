using LeetCodeProblems.ArrayProblems.Leetcode_2221_FindTriangularSumOfAnArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2221_FindTriangularSumOfAnArray
{
    [TestClass]
    public class Leetcode_2221_FindTriangularSumOfAnArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateTriangularSum_Then_ShouldReturnTriangularSum()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5 };
            var problem = new Leetcode_2221_FindTriangularSumOfAnArray_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.CalculateTriangularSum(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
