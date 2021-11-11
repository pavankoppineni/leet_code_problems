using LeetCodeProblems.TreeProblems.Leetcode_654_MaximumBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_654_MaximumBinaryTree
{
    [TestClass]
    public class Leetcode_654_MaximumBinaryTree_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_ConstructMaxBinaryArray_Then_ShouldReturnMaximumBinaryArray()
        {
            //Given
            var values = new int[] { 3, 2, 1, 6, 0, 5 };
            var problem = new Leetcode_654_MaximumBinaryTree_V2();
            var expectedResult = new Node654_V2();

            //When
            var actualResult = problem.Construct(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
