using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2547_MinimumCostToSplitArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerValuesAndK_When_CalculateMinimumCost_Then_ShouldReturnMinimumCost()
        {
            //Given
            var values = new int[] { 1, 2, 1, 2, 1 };
            var k = 5;
            var problem = new Leetcode_2547_MinimumCostToSplitArray_V1();
            var expectedResult = 6;

            //When
            var actualResult = problem.CalculateMinumumCost(values, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
