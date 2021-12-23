using LeetCodeProblems.DynamicProgramming.Leetcode_45_JumpGame_II;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_45_JumpGame2_II
{
    [TestClass]
    public class Leetcode_45_JumpGame2_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindLeastJumps_Then_ShouldReturnLeastJumps()
        {
            //Given
            var jumps = new int[] { 2, 3, 1, 1 };
            var problem = new Leetcode_45_JumpGame2_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.MinJumps(jumps);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
