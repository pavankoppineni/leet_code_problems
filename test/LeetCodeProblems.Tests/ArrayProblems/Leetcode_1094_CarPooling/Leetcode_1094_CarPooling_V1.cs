using LeetCodeProblems.ArrayProblems.Leetcode_1094_CarPooling;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_1094_CarPooling
{
    [TestClass]
    public class Leetcode_1094_CarPooling_V1Tests
    {
        [TestMethod]
        public void Given_Trips_When_CarPooling_Then_ShouldReturnTrueIfDriverCanTakeAllPassengers()
        {
            //Given
            var trips = new int[2][]
            {
                new int[3]{9,0,1},
                new int[3]{ 3, 3, 7 }
            };
            var capacity = 4;
            var expectedResult = false;
            var problem = new Leetcode_1094_CarPooling_V1();

            //When
            var actualResult = problem.CarPooling(trips, capacity);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
