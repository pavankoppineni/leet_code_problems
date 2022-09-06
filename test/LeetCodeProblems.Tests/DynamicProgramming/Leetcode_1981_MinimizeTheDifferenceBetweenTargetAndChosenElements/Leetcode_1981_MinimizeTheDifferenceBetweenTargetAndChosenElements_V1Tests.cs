using LeetCodeProblems.DynamicProgramming.Leetcode_1981_MinimizeTheDifferenceBetweenTargetAndChosenElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_1981_MinimizeTheDifferenceBetweenTargetAndChosenElements
{
    [TestClass]
    public class Leetcode_1981_MinimizeTheDifferenceBetweenTargetAndChosenElements_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_CalculateMinimizeDifference_Then_ShouldReturnMinimumDiffeence()
        {
            //Given
            var matrix = new int[3][]
            {
                new int[]{1,2,3},
                new int[]{4,5,6},
                new int[]{7,8,9},
            };
            var target = 13;
            var problem = new Leetcode_1981_MinimizeTheDifferenceBetweenTargetAndChosenElements_V1();
            var expectedResult = 0;

            //When
            var actualResult = problem.CalculateMinimumDifference(matrix, target);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
