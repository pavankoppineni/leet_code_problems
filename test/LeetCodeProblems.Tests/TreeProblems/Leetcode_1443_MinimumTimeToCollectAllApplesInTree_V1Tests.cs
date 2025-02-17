using LeetCodeProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_1443_MinimumTimeToCollectAllApplesInTree_V1Tests
    {
        [TestMethod]
        public void Test()
        {
            //Given
            var nodes = 4;
            var edges = new int[3][]
            {
                new int[]{0,2},
                new int[]{0,3},
                new int[]{1,2}
            };
            var apples = new List<bool>
            {
                false,
                true,
                false,
                false
            };
            var problem = new Leetcode_1443_MinimumTimeToCollectAllApplesInTree_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.CalculateMinimumTime(nodes, edges, apples);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
