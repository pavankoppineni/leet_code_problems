using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class LeetCode_57_InsertInterval_V1Tests
    {
        [TestMethod]
        public void Given_IntervalsAndNewInterval_When_Insert_Then_ShouldReturnUpdatedIntervals()
        {
            //Given
            var intervals = new List<int[]>();
            intervals.Add(new int[] { 1, 5});
            var newInterval = new int[] { 0, 3 };

            var problem = new LeetCode_57_InsertInterval_V1();
            var expectedResult = new int[1][];
            expectedResult[0] = new int[] { 0, 5 };

            //When
            var actualResult = problem.Insert(intervals.ToArray(), newInterval);

            //Then
            Assert.AreEqual(expectedResult[0][0], actualResult[0][0]);
            Assert.AreEqual(expectedResult[0][1], actualResult[0][1]);
        }
    }
}
