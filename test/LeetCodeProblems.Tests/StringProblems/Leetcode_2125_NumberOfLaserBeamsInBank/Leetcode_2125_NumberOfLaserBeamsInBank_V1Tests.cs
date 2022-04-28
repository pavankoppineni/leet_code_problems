using LeetCodeProblems.StringProblems.Leetcode_2125_NumberOfLaserBeamsInBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems.Leetcode_2125_NumberOfLaserBeamsInBank
{
    [TestClass]
    public class Leetcode_2125_NumberOfLaserBeamsInBank_V1Tests
    {
        [TestMethod]
        public void Given_BankCameras_When_CalcuateBeams_Then_ShouldReturnNumberOfBeams()
        {
            //Given
            var cameras = new string[] { "000", "111", "111" };
            var problem = new Leetcode_2125_NumberOfLaserBeamsInBank_V1();
            var expectedResult = 9;

            //When
            var actualResult = problem.CalclulateLaserBeams(cameras);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
