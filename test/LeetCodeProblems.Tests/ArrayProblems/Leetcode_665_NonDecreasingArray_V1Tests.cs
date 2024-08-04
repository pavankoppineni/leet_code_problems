using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_665_NonDecreasingArray_V1Tests
    {
        [TestMethod]
        public void Given_Numbers_When_Calculate()
        {
            //Given
            var problem = new Leetcode_665_NonDecreasingArray_V1();
            var values = new int[] { 1, 2, 2, 1, 1 }; //{ 3, 4, 2, 3 };
            var expectedResult = false;

            //When
            var actualResult = problem.CheckPossibility(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
