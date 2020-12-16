using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_556_NextGreaterElementIII_V1Tests
    {
        private static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>();
            dataset.Add(new object[]
            {
                2147483647,
                62378
            });
            dataset.Add(new object[]
            {
                12345,
                1
            });
            dataset.Add(new object[]
            {
                54321,
                -1
            });

            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_Number_When_FindNextGreaterElement_Then_ShouldReturnNextGreaterElement(int number, int expectedMinIndex)
        {
            //Given
            var problem = new Leetcode_556_NextGreaterElementIII_V1();

            //When
            var actualMinIndex = problem.NextGreaterElement(number);

            //Then
            Assert.Fail();
        }
    }
}
