using LeetCodeProblems.SlidingWindowProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.SlidingWindowProblems
{
    [TestClass]
    public class Leetcode_2841_MaximumSumOfAlmostUniqueSubarray_V1Tests
    {
        [TestMethod]
        public void Given_Numbers_When_CalculateMaxSum_Then_ShouldReturnMaxSum()
        {
            //Given
            var numbers = new List<int>()
            {
                2,6,7,3,1,7
            };
            var k = 1;
            var m = 7;
            var problem = new Leetcode_2841_MaximumSumOfAlmostUniqueSubarray_V1();
            var expectedResult = 18;

            //When
            var actualResult = problem.CalculateMaximumSum(numbers, k, m);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
