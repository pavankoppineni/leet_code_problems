using LeetCodeProblems.Greedy.Leetcode_870_AdvantageShuffle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_870_AdvantageShuffle
{
    [TestClass]
    public class Leetcode_870_AdvantageShuffle_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArrays_When_Shuffle_Then_ShouldReturnAdvantageArray()
        {
            //Given
            var arrayOne = new int[] { 12, 24, 8, 32 };
            var arrayTwo = new int[] { 13, 25, 32, 11 };
            var expectedResult = new int[] { 13, 25, 32, 11 };
            var problem = new Leetcode_870_AdvantageShuffle_V1();

            //When
            var actualResult = problem.CalcualteAdvantage(arrayOne, arrayTwo);

            //Then
            for(var index = 0; index < arrayOne.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}
