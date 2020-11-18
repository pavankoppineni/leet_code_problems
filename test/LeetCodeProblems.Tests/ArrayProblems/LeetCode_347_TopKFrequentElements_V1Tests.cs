using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class LeetCode_347_TopKFrequentElements_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegersAndElementK_When_FindTopKElements_Then_ShouldReturnTopKElements()
        {
            //Given
            var values = new int[] { 1, 1, 2, 3, 3 };
            var k = 2;
            var problem = new LeetCode_347_TopKFrequentElements_V1();
            var expectedResult = new int[] { 1, 3 };

            //When
            var actualResult = problem.TopKFrequent(values, k);

            //Then
            Array.Sort(expectedResult);
            Array.Sort(actualResult);
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            for(var i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
