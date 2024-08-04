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
    public class Leetcode_2007_FindOriginalArrayFromDoubledArray_V1Tests
    {
        [TestMethod]
        public void Given_Values_When_CalculateOriginalArray_Then_ShouldReturnOriginalArray()
        {
            //Given
            var values = new int[] { 1, 2, 3, 2, 4, 6, 2, 4, 6, 4, 8, 12 };
            var problem = new Leetcode_2007_FindOriginalArrayFromDoubledArray_V1();
            var expectedResult = new int[] { 1, 3, 4 };

            //When
            var actualResult = problem.CalculateOriginalArray(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
