using LeetCodeProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_1376_TimeNeededToInformAllEmployees_V1Tests
    {
        [TestMethod]
        public void Given_Managers_When_CalculateNumberOfMinutes_Then_ShouldReturnNumberOfMinutes()
        {
            //Given
            var n = 6;
            var headId = 2;
            var managers = new int[] { 2, 2, -1, 2, 2, 2 };
            var informTime = new int[] { 0, 0, 1, 0, 0, 0 };
            var problem = new Leetcode_1376_TimeNeededToInformAllEmployees_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateNumberOfMinutes(n, headId, managers, informTime);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
