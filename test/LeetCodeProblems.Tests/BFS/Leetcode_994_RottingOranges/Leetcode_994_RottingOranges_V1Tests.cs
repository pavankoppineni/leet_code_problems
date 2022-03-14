using LeetCodeProblems.BFS.Leetcode_994_RottingOranges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BFS.Leetcode_994_RottingOranges
{
    [TestClass]
    public class Leetcode_994_RottingOranges_V1Tests
    {
        [TestMethod]
        public void Given_OrangeGrid_When_CalculateMinTime_Then_ShouldReturnMinTimeToRot()
        {
            //Given
            var grid = new int[][]
            {
                new int[]{ 2,1,1},
                new int[]{1,1,0},
                new int[]{0,1,1}
            };
            var problem = new Leetcode_994_RottingOranges_V1();
            var expectedMinTime = 4;
            //When
            var actualMinTime = problem.CalculateMinimumMinutesToRot(grid);

            //Then
            Assert.AreEqual(expectedMinTime, actualMinTime);
        }
    }
}
