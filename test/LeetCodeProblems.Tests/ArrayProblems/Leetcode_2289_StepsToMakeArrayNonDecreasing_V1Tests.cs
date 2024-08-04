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
    public class Leetcode_2289_StepsToMakeArrayNonDecreasing_V1Tests
    {
        [TestMethod]
        public void Given_Integers_When_CalculateMaxSteps_Then_ShouldReturnSteps()
        {
            //Given
            var problem = new Leetcode_2289_StepsToMakeArrayNonDecreasing_V1();
            var values = new int[] { 5, 3, 4, 4, 7, 3, 6, 11, 8, 5, 11 };
            var expectedValue = 3;

            //When
            var actualResult = problem.CalculateNumberOfSteps(values);

            //Then
            Assert.AreEqual(expectedValue, actualResult);
        }
    }
}
