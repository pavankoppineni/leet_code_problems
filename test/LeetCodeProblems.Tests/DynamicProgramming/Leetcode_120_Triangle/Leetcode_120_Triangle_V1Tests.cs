using LeetCodeProblems.DynamicProgramming.Leetcode_120_Triangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_120_Triangle
{
    [TestClass]
    public class Leetcode_120_Triangle_V1Tests
    {
        [TestMethod]
        public void Given_Triangle_When_CalculateMinimumPath_Then_ShouldReturnMinimumPath()
        {
            //Given
            var triangle = new List<IList<int>>();
            triangle.Add(new List<int>() { 2 });
            triangle.Add(new List<int>() { 3, 4 });
            triangle.Add(new List<int>() { 5, 6, 7 });
            var problem = new Leetcode_120_Triangle_V1();
            var expectedResult = 10;

            //When
            var actualResult = problem.CalculateMinimumPath(triangle);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
