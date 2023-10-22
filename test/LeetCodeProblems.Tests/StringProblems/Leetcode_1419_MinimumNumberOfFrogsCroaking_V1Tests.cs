using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_1419_MinimumNumberOfFrogsCroaking_V1Tests
    {
        [TestMethod]
        public void Given_CroakingFrogs_When_CalculateMinimumNumberOfFrogs_Then_ShouldReturnFrongs()
        {
            //Given
            var croakOfFrogs = "croakcroak";
            var problem = new Leetcode_1419_MinimumNumberOfFrogsCroaking_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMinimumFrogs(croakOfFrogs);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
