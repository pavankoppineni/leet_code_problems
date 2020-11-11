using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class LeetCode_1283_V1Tests
    {
        [TestMethod]
        public void Given_NumbersAndThreshold_When_FindSmallestDivisor_Then_ShouldReturnSmallestDivisor()
        {
            //Given
            var problem = new LeetCode_1283_V1();
            var threshold = 6;
            var nums = new int[] { 1, 2, 5, 9 };
            var expectedResult = 5;

            //When
            var actualResult = problem.FindSmallestDivisor(nums, threshold);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
