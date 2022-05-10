using LeetCodeProblems.ArrayProblems.Leetcode_1672_RichestCustomerWealth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_1672_RichestCustomerWealth
{
    [TestClass]
    public class Leetcode_1672_RichestCustomerWealth_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_CalculateMaxWealth_Then_ReturnMaxWealth()
        {
            //Given
            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 1, 2, 3 };
            matrix[2] = new int[] { 1, 2, 3 };
            var problem = new Leetcode_1672_RichestCustomerWealth_V1();
            var expectedWealth = 6;

            //When
            var actualWealth = problem.CalculateMaximumWealth(matrix);

            //Then
            Assert.AreEqual(expectedWealth, actualWealth);
        }
    }
}
