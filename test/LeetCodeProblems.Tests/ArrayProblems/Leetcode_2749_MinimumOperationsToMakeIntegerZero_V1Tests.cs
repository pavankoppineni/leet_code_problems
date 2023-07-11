using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2749_MinimumOperationsToMakeIntegerZero_V1Tests
    {
        [TestMethod]
        public void Given_NumberOneAndNumberTwo_When_CalculateMinimumOperations_Then_ShouldReturnMinimumOperations()
        {
            //Given
            var num1 = 10;
            var num2 = 2;
            var problem = new Leetcode_2749_MinimumOperationsToMakeIntegerZero_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMinimumOperations(num1, num2);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
