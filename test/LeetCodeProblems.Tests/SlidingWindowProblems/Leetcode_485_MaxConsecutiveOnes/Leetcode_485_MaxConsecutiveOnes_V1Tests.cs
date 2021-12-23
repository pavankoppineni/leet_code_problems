using LeetCodeProblems.SlidingWindowProblems.Leetcode_485_MaxConsecutiveOnes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.SlidingWindowProblems.Leetcode_485_MaxConsecutiveOnes
{
    [TestClass]
    public class Leetcode_485_MaxConsecutiveOnes_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindMaximumConsecutiveOnes_Then_ShouldReturnLengthOfMaxConsecutiveOnes()
        {
            //Given
            var arr = new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0 };
            var problem = new Leetcode_485_MaxConsecutiveOnes_V1();
            var expectedResult = 5;

            //When
            var actualResult = problem.FindMaxConsecutiveOnes(arr);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
