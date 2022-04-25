using LeetCodeProblems.Greedy.Leetcode_134_GasStation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_134_GasStation
{
    [TestClass]
    public class Leetcode_134_GasStation_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateGasStation_Then_ShouldReturnGasStation()
        {
            //Given
            var gas = new int[] { 2 };
            var costs = new int[] { 2 };
            var problem = new Leetcode_134_GasStation_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateGasStation(gas, costs);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
