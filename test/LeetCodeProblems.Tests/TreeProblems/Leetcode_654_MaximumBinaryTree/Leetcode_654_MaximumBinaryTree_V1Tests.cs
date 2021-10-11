using LeetCodeProblems.TreeProblems.Leetcode_654_MaximumBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_654_MaximumBinaryTree
{
    [TestClass]
    public class Leetcode_654_MaximumBinaryTree_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_ConstructMaximumBinaryTree_Then_ShouldReturnMaximumBinaryTree()
        {
            //Given
            var values = new int[] { 3, 2, 1, 6, 0, 5 };
            var problem = new Leetcode_654_MaximumBinaryTree_V1();
            var expectedResult = new object[] { };

            //When
            var actualResult = problem.ConstructMaximumBinaryTree(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
