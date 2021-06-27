using LeetCodeProblems.LinkedListProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static LeetCodeProblems.LinkedListProblems.Leetcode_1721_SwppingNodesInLinkedList_V1;

namespace LeetCodeProblems.Tests.LinkedListProblems
{
    [TestClass]
    public class Leetcode_1721_SwppingNodesInLinkedList_V1Tests
    {
        [TestMethod]
        public void Given_LinkedList_When_SwapNodes_Then_ShouldSwapNodes()
        {
            //Given
            var node = CreateLinkedList(5);
            var problem = new Leetcode_1721_SwppingNodesInLinkedList_V1();
            var k = 2;

            //When
            var actualLinkedList = problem.SwapNodes(node, k);

            //Then
            Assert.Fail();
        }

        private static Node1721 CreateLinkedList(int count)
        {
            Node1721 head = null;
            Node1721 previous = null;
            var current = 1;
            while (current <= count)
            {
                var node = new Node1721 { Value = current };
                if (previous != null)
                {
                    previous.Next = node;
                }
                else
                {
                    head = node;
                }
                previous = node;
                current += 1;
            }
            return head;
        }
    }
}
