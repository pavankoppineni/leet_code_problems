using LeetCodeProblems.DynamicProgramming.Leetcode_799_ChampagneTower;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_799_ChampagneTower
{
    [TestClass]
    public class Leetcode_799_ChampagneTower_V1Tests
    {
        [TestMethod]
        public void Given_CupsAndRowIndexAndGlassIndex_When_FindQuantity_Then_ShouldReturnQuantityOfWater()
        {
            //Given
            var rowIndex = 0;
            var buckets = 1;
            var glassIndex = 0;
            var problem = new Leetcode_799_ChampagneTower_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.ChampagneTower(buckets, rowIndex, glassIndex);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
