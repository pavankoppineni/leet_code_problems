using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_904_FruitIntoBaskets_V1Tests
    {
        [TestMethod]
        public void Given_Fruits_When_CalculateMaximumFruits_Then_ShouldReturnMaxFruits()
        {
            //Given
            var fruits = new int[] { 1, 2, 1, 1, 2, 3 };
            var problem = new Leetcode_904_FruitIntoBaskets_V1();
            var expectedResult = 5;

            //When
            var actualResult = problem.CalculateMaximumNumberOfFruits(fruits);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
