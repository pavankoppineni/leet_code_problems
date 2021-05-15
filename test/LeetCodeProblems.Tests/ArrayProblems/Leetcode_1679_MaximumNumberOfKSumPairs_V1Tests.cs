using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1679_MaximumNumberOfKSumPairs_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntergersAndSum_When_MaximumNumberOfPairs_Then_ShouldReturnCountOfPairs()
        {
            //Given
            var values = new int[] { 3, 1, 3, 4, 3 };
            var target = 6;
            var problem = new Leetcode_1679_MaximumNumberOfKSumPairs_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.FindPairs(values, target);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
