using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2766_RelocateMarbles_V1Tests
    {
        [TestMethod]
        public void Given_Marbles_When_Relocate_Then_ShouldReturnFinalPositions()
        {
            //Given
            var marbles = new int[] { 3, 4};
            var from = new int[] { 4, 3, 1, 2, 2, 3, 2, 4, 1 };
            var to = new int[] { 3, 1, 2, 2, 3, 2, 4, 1, 1 };
            var problem = new Leetcode_2766_RelocateMarbles_V1();
            var expectedResult = new int[1] { 1 };

            //When
            var actualResult = problem.CalculareFinalPositions(marbles, from, to);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
