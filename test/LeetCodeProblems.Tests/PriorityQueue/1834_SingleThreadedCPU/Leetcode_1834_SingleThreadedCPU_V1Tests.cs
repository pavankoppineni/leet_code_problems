using LeetCodeProblems.PriorityQueue._1834_SingleThreadedCPU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.PriorityQueue._1834_SingleThreadedCPU
{
    [TestClass]
    public class Leetcode_1834_SingleThreadedCPU_V1Tests
    {
        [TestMethod]
        public void Given_Tasks_When_GetOrder_Then_ShouldReturnTheOrder()
        {
            //Given
            var tasks = new int[2][]
            {
                new int[] { 2, 3 },
                new int[] { 4, 5 }
            };
            var problem = new Leetcode_1834_SingleThreadedCPU_V1();

            //When
            problem.GetOrder(tasks);

            //Then
            Assert.Inconclusive();
        }
    }
}
