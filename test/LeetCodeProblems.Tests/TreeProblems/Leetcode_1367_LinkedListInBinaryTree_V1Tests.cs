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
    public class Leetcode_1367_LinkedListInBinaryTree_V1Tests
    {
        [TestMethod]
        public void Test()
        {
            //Given
            var head = new ListNode1367
            {
                val = 2
            };
            var next = new ListNode1367
            {
                val = 2
            };
            var next1 = new ListNode1367
            {
                val = 1
            };
            head.next = next;
            next.next = next1;

            var root = Create(2);
            var node12 = Create(2);
            var node22 = Create(2);
            var node32 = Create(1);
            root.right = node12;
            node12.right = node22;
            node22.right = node32;
            var problem = new Leetcode_1367_LinkedListInBinaryTree_V1();
            var expectedResult = true;
            var values = new List<int>()
            {
                1,10,3,7,10,8,9,5,3,9,6,8,7,6,6,3,5,4,4,9,6,7,9,6,9,4,9,9,7,1,5,5,10,4,4,10,7,7,2,4,5,5,2,7,5,8,6,10,2,10,1,1,6,1,8,4,7,10,9,7,9,9,7,7,7,1,5,9,8,10,5,1,7,6,1,2,10,5,7,7,2,4,10,1,7,10,9,1,9,10,4,4,1,2,1,1,3,2,6,9
            };

            //When
            var lps = problem.ConstructLPS(values);
            var actualResult = problem.IsSubPath(head, root);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }

        public static TreeNode1367 Create(int val)
        {
            return new TreeNode1367 { val = val };
        }
    }
}
