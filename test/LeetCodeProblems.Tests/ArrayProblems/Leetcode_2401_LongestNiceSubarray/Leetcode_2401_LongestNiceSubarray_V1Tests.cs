using LeetCodeProblems.ArrayProblems.Leetcode_2401_LongestNiceSubarray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2401_LongestNiceSubarray
{
    [TestClass]
    public class Leetcode_2401_LongestNiceSubarray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateLongestNiceSubarray_Then_ShouldReturnLongestNiceSubarray()
        {
            //Given
            var values = new int[] { 3, 1, 5, 11, 13 }; //{ 84139415, 693324769, 614626365, 497710833, 615598711, 264, 65552, 50331652, 1, 1048576, 16384, 544, 270532608, 151813349, 221976871, 678178917, 845710321, 751376227, 331656525, 739558112, 267703680 };
            var problem = new Leetcode_2401_LongestNiceSubarray_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.FindLongestNiceSubarray(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
