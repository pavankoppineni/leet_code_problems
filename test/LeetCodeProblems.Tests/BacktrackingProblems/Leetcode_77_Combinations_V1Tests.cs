using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_77_Combinations_V1Tests
    {
        [TestMethod]
        public void Given_RangeAndK_When_GenerateCombinations_Then_ShouldGenerateCombinations()
        {
            //Given
            var n = 4;
            var k = 2;
            var problem = new Leetcode_77_Combinations_V1();
            var expectedResult = new List<IList<int>>()
            {
                new List<int>{1, 2 },
                new List<int>{1, 3 },
                new List<int>{1, 4 },
                new List<int>{2, 3 },
                new List<int>{2, 4 },
                new List<int>{3, 4 },
            };

            //When
            var actualResult = problem.GenerateCombinations(n, k);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
    }
}
