using LeetCodeProblems.TreeProblems.Leetcode_100_SameTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_100_SameTree
{
    [TestClass]
    public class Leetcode_100_SameTree_V1Tests
    {
        [TestMethod]
        public void Given_TwoSameTrees_When_FindTreesAreSame_Then_ShouldReturnTrue()
        {
            //Given
            var treeOne = new TreeNode() { val = 1 };
            treeOne.right = new TreeNode() { val = 2 };
            treeOne.left = new TreeNode() { val = 3 };

            var treeTwo = new TreeNode() { val = 1 };
            treeTwo.right = new TreeNode() { val = 2 };
            treeTwo.left = new TreeNode() { val = 3 };

            var problem = new Leetcode_100_SameTree_V1();

            //When
            var actualResult = problem.IsIdentical(treeOne, treeTwo);

            //Then
            Assert.IsTrue(actualResult);
        }
    }
}
