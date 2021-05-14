using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1299_ReplaceElementWithGreatestElementOnRightSide_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_ReplaceElementWithGreatestElement_Then_ShouldReturnModifiedArray()
        {
            //Given
            var values = new int[] { 7, 1, 8 };
            var expectedValues = new int[] { 8, 8, -1 };
            var problem = new Leetcode_1299_ReplaceElementWithGreatestElementOnRightSide_V1();

            //When
            var actualValues = problem.ReplaceElements(values);

            //Then
            Assert.AreEqual(expectedValues.Length, actualValues.Length);
            for (var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}
