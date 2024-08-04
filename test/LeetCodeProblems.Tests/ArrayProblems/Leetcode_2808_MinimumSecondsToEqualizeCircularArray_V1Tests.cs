using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2808_MinimumSecondsToEqualizeCircularArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegetArray_When_CalculateMinimumSeconds_Then_ShouldReturnMinimumSeconds()
        {
            //Given
            var values = new int[] { 2, 1, 3, 3, 2 };
            var problem = new Leetcode_2808_MinimumSecondsToEqualizeCircularArray_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMinimumNumberOfSeconds(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
