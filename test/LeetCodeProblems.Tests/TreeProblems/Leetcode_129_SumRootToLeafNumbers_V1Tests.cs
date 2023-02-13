using LeetCodeProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_129_SumRootToLeafNumbers_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_SumRoot_Then_ShouldReturnRootSum()
        {
            //Given
            var tree = new TreeNode129 { val = 1 };
            tree.left = new TreeNode129 { val = 0 };
            var problem = new Leetcode_129_SumRootToLeafNumbers_V1();
            var expectedResult = 100;

            //When
            var actualResult = problem.CalculateSum(tree);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
