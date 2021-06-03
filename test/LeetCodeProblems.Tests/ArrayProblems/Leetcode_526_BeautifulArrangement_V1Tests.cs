using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_526_BeautifulArrangement_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_CountArrangement_Then_ShouldReturnCountOfArrangements()
        {
            //Given
            var number = 3;
            var problem = new Leetcode_526_BeautifulArrangement_V1();
            var expectedCount = 1;

            //When
            var actualCount = problem.CountArrangement(number);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
