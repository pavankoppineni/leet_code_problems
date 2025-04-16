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
    public class Leetcode_853_CarFleet_V1Tests
    {
        [TestMethod]
        public void Given_Cars_When_CalcualteNumberOfCarFleets_Then_ShouldReturnCountOfCarFleet()
        {
            //Given
            var positions = new int[] { 10, 8, 0, 5, 3 };
            var speed = new int[] { 2,4,1,1, 3 };
            var target = 12;
            var problem = new Leetcode_853_CarFleet_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateCarFleet(target, positions, speed);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
