using LeetCodeProblems.DynamicProgramming.Leetcode_416_PartitionEqualSubsetSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_416_PartitionEqualSubsetSum
{
    [TestClass]
    public class Leetcode_416_PartitionEqualSubsetSum_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_PartitionEqualSubsetSum_Then_ShouldReturnTrueIfArrayCanBeDividedIntoTwoEqualSets()
        {
            //Given
            var values = new int[] { 23, 13, 11, 7, 6, 5, 5 };
            var problem = new Leetcode_416_PartitionEqualSubsetSum_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.CanPartition(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
