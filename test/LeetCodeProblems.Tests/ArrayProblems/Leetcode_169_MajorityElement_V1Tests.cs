using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_169_MajorityElement_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfNumbers_When_FindMajorityElement_Then_ShouldReturnMajorityElementFromArray()
        {
            //Given
            var numbers = new int[] { 1, 2, 3, 2 };
            var problem = new Leetcode_169_MajorityElement_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.FindMajorityElement(numbers);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
