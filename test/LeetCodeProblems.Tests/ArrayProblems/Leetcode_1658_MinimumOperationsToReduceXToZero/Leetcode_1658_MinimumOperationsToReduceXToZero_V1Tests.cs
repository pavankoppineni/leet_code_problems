using LeetCodeProblems.ArrayProblems.Leetcode_1658_MinimumOperationsToReduceXToZero;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_1658_MinimumOperationsToReduceXToZero
{
    [TestClass]
    public class Leetcode_1658_MinimumOperationsToReduceXToZero_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArrayAndNumber_When_FindMinimumOperationsToReduce_Then_ShouldReturnMinimumOperations()
        {
            //Given
            var problem = new Leetcode_1658_MinimumOperationsToReduceXToZero_V1();
            var values = new int[] { 7, 1, 1, 4, 2, 3 };
            var number = 5;
            var expectedResult = 2;

            //When
            var actualResult = problem.CalcualteMinimumNumberOfOperations(values, number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
