using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class LeetCode_303_RangeSumQueryImmutableV1Tests
    {
        private static IList<object[]> RangeSumTestData
        {
            get
            {
                var testData = new List<object[]>();

                //Test Case One
                testData.Add(new object[]
                {
                    new int[]{ -2, 0, 3, -5, 2, -1 },
                    new List<(int left, int right, int expectedResult)>
                    {
                        (left : 0, right : 3, expectedResult : -4),
                        (left : 1, right : 4, expectedResult : 0),
                        (left : 2, right : 5, expectedResult : -1)
                    }
                });

                return testData;
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(RangeSumTestData),  DynamicDataSourceType.Property)]
        public void Given_ArrayOfIntegersAndRanges_When_GetRangeSum_Then_ShouldReturnSumWithInRange(int[] nums, IList<(int left, int right, int expectedResult)> ranges)
        {
            //Given
            var problem = new LeetCode_303_RangeSumQueryImmutableV1(nums);

            //When
            //Then
            foreach(var range in ranges)
            {
                var actualResult = problem.GetRangeSum(range.left, range.right);
                Assert.AreEqual(range.expectedResult, actualResult);
            }
        }
    }
}
