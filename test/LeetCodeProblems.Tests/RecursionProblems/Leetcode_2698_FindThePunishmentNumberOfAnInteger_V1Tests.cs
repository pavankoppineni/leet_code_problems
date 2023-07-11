using LeetCodeProblems.RecursionProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.RecursionProblems
{
    [TestClass]
    public class Leetcode_2698_FindThePunishmentNumberOfAnInteger_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_CalculatePunishmentNumber_Then_ShouldReturnPunishmentNumber()
        {
            //Given
            var number = 1296;
            var problem = new Leetcode_2698_FindThePunishmentNumberOfAnInteger_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.IsPunishmentNumber(number, 36);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
