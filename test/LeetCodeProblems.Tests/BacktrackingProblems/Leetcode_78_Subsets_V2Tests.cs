using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_78_Subsets_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_GenerateSubsets_Then_ShouldGenerateSubsets()
        {
            //Given
            var values = new int[] { 1, 2, 3 };
            var problem = new Leetcode_78_Subsets_V2();
            var expectedSubsets = new List<IList<int>>
            {
                new List<int>{ },
                new List<int>{ 1 },
                new List<int>{ 2 },
                new List<int>{ 3 },
                new List<int>{ 1, 2 },
                new List<int>{ 1, 3 },
                new List<int>{ 2, 3 },
                new List<int>{ 1, 2, 3 },
            };

            //When
            var actualSubsets = problem.GenerateSubsets(values);

            //Then
            Assert.AreEqual(expectedSubsets.Count, actualSubsets.Count);
        }
    }
}
