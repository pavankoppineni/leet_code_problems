using LeetCodeProblems.StringProblems.Leetcode_318_MaximumProductOfWordLengths;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems.Leetcode_318_MaximumProductOfWordLengths
{
    [TestClass]
    public class Leetcode_318_MaximumProductOfWordLengths_V1Tests
    {
        [TestMethod]
        public void Given_Words_When_CalculateProduct_Then_ShouldReturnMaxProduct()
        {
            //Given
            var words = new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" };
            var problem = new Leetcode_318_MaximumProductOfWordLengths_V1();
            var expectedProduct = 16;

            //When
            var actualProduct = problem.CalculateProduct(words);

            //Then
            Assert.AreEqual(expectedProduct, actualProduct);    
        }
    }
}
