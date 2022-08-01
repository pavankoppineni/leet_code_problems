using LeetCodeProblems.DynamicProgramming.Leetcode_1043_PartitionArrayForMaximumSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_1043_PartitionArrayForMaximumSum
{
    [TestClass]
    public class Leetcode_1043_PartitionArrayForMaximumSum_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMaximumSum_Then_ShouldReturnMaximumSum()
        {
            //Given
            var values = new int[] { 1, 15, 7, 9, 2, 5, 10 };
            var problem = new Leetcode_1043_PartitionArrayForMaximumSum_V1();
            var expectedSum = 84;
            var subArraySize = 3;

            //When
            var actualSum = problem.CalculateMaximumSum(values, subArraySize);

            //Then
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
