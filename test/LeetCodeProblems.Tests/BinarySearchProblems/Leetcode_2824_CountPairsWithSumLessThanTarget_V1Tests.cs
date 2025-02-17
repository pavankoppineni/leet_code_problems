using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class Leetcode_2824_CountPairsWithSumLessThanTarget_V1Tests
    {
        public void Test()
        {
            //Given
            var nums = new List<int>() { -1, 1, 2, 3, 1 };
            var target = 2;
            var problem = new Leetcode_2824_CountPairsWithSumLessThanTarget_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CountPairs(nums, target);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
