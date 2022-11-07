using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_462_MinimumMovesToEqualArrayElementsII_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMinimumMoves_Then_ShouldReturnMinimumMoves()
        {
            //Given
            var problem = new Leetcode_462_MinimumMovesToEqualArrayElementsII_V1();
            var numbers = new int[] { 1, 2, 3, 102 };
            var expectedResult = 202;

            //When
            var actaulResult = problem.CalculateMinimumNumberOfMoves(numbers);

            //Then
            Assert.AreEqual(expectedResult, actaulResult);
        }
    }
}
