using LeetCodeProblems.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BitManipulation
{
    [TestClass]
    public class Leetcode_2683_NeighboringBitwiseXOR_V1Tests
    {
        [TestMethod]
        public void Given_DerivedValues_When_CalculateOriginalValues_Then_ShouldReturn()
        {
            //Given
            var derived = new int[] { 1, 1, 1, 0 };
            var problem = new Leetcode_2683_NeighboringBitwiseXOR_V1();
            var expectedResult = false;

            //When
            var actualResult = problem.DoesValidArrayExist(derived);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
