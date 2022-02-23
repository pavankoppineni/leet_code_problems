using LeetCodeProblems.Greedy.Leetcode_1561_MaximumNumberOfCoinsYouCanGet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_1561_MaximumNumberOfCoinsYouCanGet
{
    [TestClass]
    public class Leetcode_1561_MaximumNumberOfCoinsYouCanGet_V1Tests
    {
        [TestMethod]
        public void Given_Coins_When_MaxCoins_Then_ShouldReturnMaxCoinsSum()
        {
            //Given
            var arr = new int[] { 9, 8, 7, 6, 5, 1, 2, 3, 4 };
            var problem = new Leetcode_1561_MaximumNumberOfCoinsYouCanGet_V1();
            var expectedResult = 18;

            //When
            var actualResult = problem.MaxCoins(arr);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
