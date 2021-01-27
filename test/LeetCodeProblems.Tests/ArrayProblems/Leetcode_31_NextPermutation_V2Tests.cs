using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_31_NextPermutation_V2Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[] { 5, 4, 3, 2, 1 },
                    new int[] { 1, 2, 3, 4, 5 }
                },
                new object[]
                {
                    new int[] { 1, 2, 3, 4, 5, 3, 2, 1 },
                    new int[] { 1, 2, 3, 5, 1, 2, 3, 4 }
                }
            };
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_ArrayOfNumbers_When_FindNextPermutation_Then_ShouldReturnNextPermutation(int[] values, int[] expectedResult)
        {
            //Given
            var problem = new Leetcode_31_NextPermutation_V2();

            //When
            var acutalResult = problem.FindNextPermutation(values);

            //Then
            for(var index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], acutalResult[index]);
            }
        }
    }
}
