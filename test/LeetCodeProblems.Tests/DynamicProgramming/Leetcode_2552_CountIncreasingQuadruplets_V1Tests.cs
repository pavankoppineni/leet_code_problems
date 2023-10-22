using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2552_CountIncreasingQuadruplets_V1Tests
    {
        [TestMethod]
        public void Given_IntegerValues_When_CountWays_Then_ShouldReturnNumberOfWays()
        {
            //Given
            var values = new int[] { 1, 3, 2, 4, 5};
            var problem = new Leetcode_2552_CountIncreasingQuadruplets_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CountNumberOfQuadruplets(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
