using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2438_RangeProductQueriesOfPowers_V1Tests
    {
        [TestMethod]
        public void Given_Queries_When_CalculateProductQueries_Then_ShouldReturnProductQueriesArray()
        {
            //Given
            var problem = new Leetcode_2438_RangeProductQueriesOfPowers_V1();
            var number = 36;
            var expectedResult = 1;
            var queries = new int[3][] 
            {
                new int[]{ 0, 1},
                new int[]{ 0, 1},
                new int[]{ 0, 1},
            };

            //When
            var actualResult = problem.CalculateProductQueries(number, queries);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Length);
        }
    }
}
