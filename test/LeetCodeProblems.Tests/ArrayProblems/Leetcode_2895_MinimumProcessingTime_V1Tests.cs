using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2895_MinimumProcessingTime_V1Tests
    {
        [TestMethod]
        public void Given_ProcessorsAndTasks_When_CalculateMinimumTime_Then_ShouldReturnMinimumTime()
        {
            //Given
            var processorsTime = new List<int> { 8, 10 };
            var tasks = new List<int> { 20, 7, 4, 5, 30, 7, 4, 5 };
            var problem = new Leetcode_2895_MinimumProcessingTime_V1();
            var expectedResult = 38;

            //When
            var actualResult = problem.CalculateMinimumProcessingTime(processorsTime, tasks);   

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
