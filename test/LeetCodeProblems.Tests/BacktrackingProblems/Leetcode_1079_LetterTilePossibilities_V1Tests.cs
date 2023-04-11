using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_1079_LetterTilePossibilities_V1Tests
    {
        [TestMethod]
        public void Given_Letters_When_GeneratePossibilities_Then_ShouldReturnPossibilities()
        {
            //Given
            var tiles = "AAB";
            var problem = new Leetcode_1079_LetterTilePossibilities_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.CalculatePossibilities(tiles);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
