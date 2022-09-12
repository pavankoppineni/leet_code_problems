using LeetCodeProblems.ArrayProblems.Leetcode_2405_OptimalPartitionOfString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2405_OptimalPartitionOfString
{
    [TestClass]
    public class Leetcode_2405_OptimalPartitionOfString_V1Tests
    {
        [TestMethod]
        public void Given_String_When_CalculateOptimalPartitions_Then_ShouldReturnNumberOfPartitions()
        {
            //Given
            var str = "ssssss";
            var problem = new Leetcode_2405_OptimalPartitionOfString_V1();
            var expectedResult = 2;

            //When
            var actaualResult = problem.CalculatePartitions(str);

            //Then
            Assert.AreEqual(expectedResult, actaualResult);
        }
    }
}
