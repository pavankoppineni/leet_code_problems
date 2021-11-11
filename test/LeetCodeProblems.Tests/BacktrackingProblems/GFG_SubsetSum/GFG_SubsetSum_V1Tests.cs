using LeetCodeProblems.BacktrackingProblems.GFG_SubsetSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class GFG_SubsetSum_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegersAndSum_When_FindSubsetSum_Then_ShouldReturnTrueIfSubsetWithSumExists()
        {
            //Given
            var values = new int[]{3, 4, 5, 2};
            var sum = 6;
            var problem = new GFG_SubsetSum_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.FindSubsetSum(values, sum);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
