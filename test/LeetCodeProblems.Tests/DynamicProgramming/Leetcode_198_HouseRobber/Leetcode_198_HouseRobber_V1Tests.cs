using LeetCodeProblems.DynamicProgramming.Leetcode_198_HouseRobber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_198_HouseRobber
{
    [TestClass]
    public class Leetcode_198_HouseRobber_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Rob_Then_ShouldReturnMaximumAmountThatCanBeRobbed()
        {
            //Given
            var houses = new int[] { 2, 7, 9, 3, 1 };
            var problem = new Leetcode_198_HouseRobber_V1();
            var expectedResult = 12;

            //When
            var actualResult = problem.Rob(houses);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
