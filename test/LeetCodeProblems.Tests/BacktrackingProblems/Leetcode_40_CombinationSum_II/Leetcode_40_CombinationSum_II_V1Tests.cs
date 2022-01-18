using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.BacktrackingProblems.Leetcode_40_CombinationSum_II;

namespace LeetCodeProblems.Tests.BacktrackingProblems.Leetcode_40_CombinationSum_II
{
    [TestClass]
    public class Leetcode_40_CombinationSum_II_V1Tests
    {
        [TestMethod]
        public void Given_CandidatesAndTarget_When_GenerateCombinations_Then_ShouldGenerateCombinations()
        {
            //Given
            var candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            var target = 8;
            var problem = new Leetcode_40_CombinationSum_II_V1();

            //When
            var actualResult = problem.GenerateCombinations(candidates, target);

            //Then
            Assert.Inconclusive();
        }
    }
}
