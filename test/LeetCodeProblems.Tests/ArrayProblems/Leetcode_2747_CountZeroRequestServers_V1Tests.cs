using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2747_CountZeroRequestServers_V1Tests
    {
        [TestMethod]
        public void Given_ServersAndLogs_When_CalculateZeroRequestServers_Then_ShouldReturnZeroRequestServers()
        {
            //Given
            var serverCount = 6;
            var logs = new int[1][]
            {
                new int[]{1,21}
            };
            var x = 10;
            var queries = new int[] { 24, 35, 28, 26, 20, 25, 16, 31, 12 };
            var problem = new Leetcode_2747_CountZeroRequestServers_V1();
            var expectedResult = new int[] { 1, 2 };

            //When
            var actualResult = problem.CalculateNumberOfZeroRequests(serverCount, logs, x, queries);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
        }
    }
}
