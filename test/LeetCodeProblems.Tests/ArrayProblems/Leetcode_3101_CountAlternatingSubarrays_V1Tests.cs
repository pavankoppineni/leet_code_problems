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
    public class Leetcode_3101_CountAlternatingSubarrays_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateNumberOfArrays_Then_ShouldCalculateNumberOfArrays()
        {
            //Given
            var values = new int[] { 1, 1, 1, 0, 1, 0, 1 };
            var problem = new Leetcode_3101_CountAlternatingSubarrays_V1();
            var expectedResult = 12;

            //When
            var actualResult = problem.CalculateNumberOfSubArrays(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
