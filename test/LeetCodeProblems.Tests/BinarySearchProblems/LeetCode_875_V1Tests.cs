using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class LeetCode_875_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfPilesAndNumberOfHours_When_Find_Then_ShouldReturnNumberOfPilesToEat()
        {
            //Given
            var values = new int[] { 30, 11, 23, 4, 20 };
            var numberOfHours = 35;
            var expectedResult = 3;
            var problem = new LeetCode_875_V1();

            //When
            var actualResult = problem.Find(values, numberOfHours);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
