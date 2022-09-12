using LeetCodeProblems.ArrayProblems.Leetcode_763_PartitionLabels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_763_PartitionLabels
{
    [TestClass]
    public class Leetcode_763_PartitionLabels_V1Tests
    {
        [TestMethod]
        public void Given_String_When_CalculatePartitions_Then_ShouldReturnPartitions()
        {
            //Given
            var str = "abbadxxd";
            var problem = new Leetcode_763_PartitionLabels_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.GeneratePartitions(str);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}
