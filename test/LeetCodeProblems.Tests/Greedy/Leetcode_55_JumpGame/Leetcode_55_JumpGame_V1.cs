using LeetCodeProblems.Greedy.Leetcode_55_JumpGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_55_JumpGame
{
    [TestClass]
    public class Leetcode_55_JumpGame_V1Tests
    {
        [TestMethod]
        public void Given_JumpArray_When_CanJump_ShouldReturnTrue()
        {
            //Given
            var values = new int[] { 2, 3, 1, 1, 4 };
            var problem = new Leetcode_55_JumpGame_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.CanJump(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Given_JumpArray_When_CanJump_ShouldReturnFalse()
        {
            //Given
            var values = new int[] { 3, 2, 1, 0, 4 };
            var problem = new Leetcode_55_JumpGame_V1();
            var expectedResult = false;

            //When
            var actualResult = problem.CanJump(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
