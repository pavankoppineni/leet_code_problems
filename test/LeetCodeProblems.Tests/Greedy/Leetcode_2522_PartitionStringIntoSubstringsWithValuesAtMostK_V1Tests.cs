using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_2522_PartitionStringIntoSubstringsWithValuesAtMostK_V1Tests
    {
        [TestMethod]
        public void Given_InputStringAndK_When_CalculateMaximumPartitions_Then_ShouldReturnMaximumPartitions()
        {
            //Given
            var str = "165462";
            var k = 60;
            var problem = new Leetcode_2522_PartitionStringIntoSubstringsWithValuesAtMostK_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateMinimumPartitions(str, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
