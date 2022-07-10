using LeetCodeProblems.ArrayProblems.Leetcode_2274_MaximumConsecutiveFloorsWithoutSpecialFloors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2274_MaximumConsecutiveFloorsWithoutSpecialFloors
{
    [TestClass]
    public class Leetcode_2274_MaximumConsecutiveFloorsWithoutSpecialFloors_V1Tests
    {
        [TestMethod]
        public void Given_FloorsAndSpecialFloors_When_CalculateConsecutiveFloors_Then_ShouldReturnConsecutiveFloors()
        {
            //Given
            var top = 9;
            var bottom = 2;
            var specialFloors = new int[] { 4, 6 };
            var problem = new Leetcode_2274_MaximumConsecutiveFloorsWithoutSpecialFloors_V1();
            var expectedResult = 3;
            
            //When
            var actualResult = problem.CalculateMaximumConsecutiveFloors(bottom, top, specialFloors);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
