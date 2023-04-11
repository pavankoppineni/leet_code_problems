using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2592_MaximizeGreatnessOfArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateGreatness_Then_ShouldReturnGreatness()
        {
            //Given
            var nums = new int[] { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3 };
            var problem = new Leetcode_2592_MaximizeGreatnessOfArray_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMaximumGreatness(nums);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
