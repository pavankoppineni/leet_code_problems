using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class GeeksForGeeks_XOR_Of_SubArray_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_CalculateXORBetweenRange_Then_ShouldRentuXORWithinTheGivenRange()
        {
            //Given
            var values = new int[] { 3, 2, 5 };
            var left = 1;
            var right = 2;
            var problem = new GeeksForGeeks_XOR_Of_SubArray_V1();
            var expectedResult = 7;

            //When
            problem.AddArray(values);
            var actualResult = problem.CalculateXOR(left, right);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
