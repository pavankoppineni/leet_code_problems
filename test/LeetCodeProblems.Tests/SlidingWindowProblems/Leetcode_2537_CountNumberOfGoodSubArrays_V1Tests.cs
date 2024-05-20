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
    public class Leetcode_2537_CountNumberOfGoodSubArrays_V1Tests
    {
        [TestMethod]
        public void Given_Numbers_When_CalcualteGoodSubArrays_Then_ShouldReturn()
        {
            //Given
            var numbers = new int[] { 3, 1, 4, 3, 2, 2, 4 };
            var problem = new Leetcode_2537_CountNumberOfGoodSubArrays_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateNumberOfSubArrays(numbers, 2);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
