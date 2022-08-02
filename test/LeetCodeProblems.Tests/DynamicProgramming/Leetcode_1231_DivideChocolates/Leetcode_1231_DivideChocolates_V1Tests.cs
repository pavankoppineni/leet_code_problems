using LeetCodeProblems.DynamicProgramming.Leetcode_1231_DivideChocolates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_1231_DivideChocolates
{
    [TestClass]
    public class Leetcode_1231_DivideChocolates_V1Tests
    {
        [TestMethod]
        public void Given_SweetnessAndFriends_When_CalculateMaximumSweetness_Then_ShouldReturnMaximumSweetness()
        {
            //Given
            var sweetness = new int[] { 1, 2, 2, 1, 2, 2, 1, 2, 2 };
            var friends = 3;
            var expectedResult = 5;
            var problem = new Leetcode_1231_DivideChocolates_V1();

            //When
            var actualResult = problem.CalculateMaximumTotalSweetness(sweetness, friends);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
