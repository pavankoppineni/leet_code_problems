using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1829_MaximumXORForEachQuery_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateXOR_Then_ReturnMaximizedXORArray()
        {
            //Given
            var values = new int[] { 0, 1, 2, 2, 5, 7 };
            var maximumBit = 3;
            var problem = new Leetcode_1829_MaximumXORForEachQuery_V1();
            var expectedResult = new int[] { 4,3,6,4,6,7 };

            //When
            var actualResult = problem.CalculateMaximumForEachQuery(values, maximumBit);

            //Then
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
