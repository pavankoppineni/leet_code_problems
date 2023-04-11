using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2579_CountTotalNumberOfColoredCells_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_CalculateColoredCells_Then_ShouldReturnNumberOfColoredCells()
        {
            //Given
            var n = 4;
            var expectedResult = 25;
            var problem = new Leetcode_2579_CountTotalNumberOfColoredCells_V1();

            //When
            var actualResult = problem.CalculateColoredCells(n);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
