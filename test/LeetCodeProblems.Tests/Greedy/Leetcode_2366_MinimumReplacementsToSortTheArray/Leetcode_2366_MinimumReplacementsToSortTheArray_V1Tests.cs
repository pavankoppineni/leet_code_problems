using LeetCodeProblems.Greedy.Leetcode_2366_MinimumReplacementsToSortTheArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_2366_MinimumReplacementsToSortTheArray
{
    [TestClass]
    public class Leetcode_2366_MinimumReplacementsToSortTheArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMinimumOperations_Then_ShouldReturnMinimumOperations()
        {
            //Given
            var values = new int[] { 12, 9, 7, 6, 17, 19, 21 };
            var problem = new Leetcode_2366_MinimumReplacementsToSortTheArray_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateMinimumReplacements(values); 
            
            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
