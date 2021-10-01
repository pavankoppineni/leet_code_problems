using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_523_Continuous_Subarray_Sum
{
    [TestClass]
    public class Leetcode_523_ContinuousSubarraySum_V1Tests
    {
        private static IEnumerable<object[]> GetTestData()
        {
            var testData = new List<object[]>();

            //Test Case 1
            testData.Add(new object[]
            {
                new int[] { 23, 2, 4, 6, 7 },
                6,
                true
            });

            return testData;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Given_IntegerArray_When_SumArraySum_Then_ShouldReturnTrueIfSumExists()
        {
            //Given
            var values = new int[] { 23, 2, 4, 6, 7 };
            var problem = new Leetcode_523_ContinuousSubarraySum_V1();
            var expectedResult = true;
            var sum = 6;

            //When
            var actualResult = problem.CheckSubArraySum(values, sum);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
