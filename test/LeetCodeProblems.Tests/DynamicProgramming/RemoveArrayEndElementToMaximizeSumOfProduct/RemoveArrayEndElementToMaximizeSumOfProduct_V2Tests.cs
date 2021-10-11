using LeetCodeProblems.DynamicProgramming.RemoveArrayEndElementToMaximizeSumOfProduct;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.RemoveArrayEndElementToMaximizeSumOfProduct
{
    [TestClass]
    public class RemoveArrayEndElementToMaximizeSumOfProduct_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_MaximizeSumOfProduct_Then_ShouldReturnMaximumSumProduct()
        {
            //Given
            var values = new int[] { 1, 2, 3 };
            var problem = new RemoveArrayEndElementToMaximizeSumOfProduct_V2();
            var expectedSum = 14;

            //When
            var actualSum = problem.FindMaximumSum(values);

            //Then
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
