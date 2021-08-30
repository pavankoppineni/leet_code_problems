using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_442_FindAllDuplicatesInArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindDuplicates_Then_ShouldReturnDuplicates()
        {
            //Given
            var values = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var expectedResult = new HashSet<int> { 2, 3 };
            var problem = new Leetcode_442_FindAllDuplicatesInArray_V1();

            //When
            var actualResult = problem.FindDuplicates(values);

            //Then
            foreach (var actualItem in actualResult)
            {
                var expected = expectedResult.Contains(actualItem);
                Assert.AreEqual(true, expected);
            }
        }
    }
}
