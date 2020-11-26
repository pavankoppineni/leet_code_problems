using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_56_MergeIntervals_V1Tests
    {
        [TestMethod]
        public void Given_Intervals_When_Merge_Then_ShouldReturnOverlappedIntervals()
        {
            //Given
            var intervals = new int[9][];
            //[[5,5],[1,3],[3,5],[4,6],[1,1],[3,3],[5,6],[3,3],[2,4]]
            intervals[0] = new int[2] { 5, 5 };
            intervals[1] = new int[2] { 1, 3 };
            intervals[2] = new int[2] { 3, 5 };
            intervals[3] = new int[2] { 4, 6 };
            intervals[4] = new int[2] { 1, 1 };
            intervals[5] = new int[2] { 3, 3 };
            intervals[6] = new int[2] { 5, 6 };
            intervals[7] = new int[2] { 3, 3 };
            intervals[8] = new int[2] { 2, 4 };

            var problem = new Leetcode_56_MergeIntervals_V1();
            var expectedResult = new int[1][];
            expectedResult[0] = new int[2] { 1, 6 };

            //When
            var actualResult = problem.Merge(intervals);

            //Then
            for (var i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i][0], actualResult[i][0]);
                Assert.AreEqual(expectedResult[i][1], actualResult[i][1]);
            }
        }
    }
}
