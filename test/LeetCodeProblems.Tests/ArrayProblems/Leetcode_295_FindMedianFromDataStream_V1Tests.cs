using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_295_FindMedianFromDataStream_V1Tests
    {
        [TestMethod]
        public void Given_StreamOfIntegers_When_AddNumAndFindMedian_Then_ShouldReturnMedianFromStreamOfIntegers()
        {
            //Given
            var problem = new Leetcode_295_FindMedianFromDataStream_V1();
            problem.AddNum(1);
            problem.AddNum(2);
            problem.AddNum(3);
            problem.AddNum(8);
            problem.AddNum(5);
            problem.AddNum(100);
            problem.AddNum(120);
            problem.AddNum(4);
            var expectedResult = 4.5;

            //When
            var actualResult = problem.FindMedian();

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
