using LeetCodeProblems.TreeProblems.Leetcode_894_AllPossibleFullBinaryTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_894_AllPossibleFullBinaryTrees
{
    [TestClass]
    public class Leetcode_894_AllPossibleFullBinaryTrees_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_GeneratePossibleFullBinaryTrees_Then_ShouldGenerateFullBinaryTrees()
        {
            //Given
            var number = 7;
            var problem = new Leetcode_894_AllPossibleFullBinaryTrees_V1();

            //When
            var actualFullBinaryTrees = problem.GenerateAllPossibleFullBinaryTrees(number);

            //Then
            Assert.Inconclusive();
        }
    }
}
