using LeetCodeProblems.MatrixProblems.Leetcode_1222_QueensThatCanAttackKing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_1222_QueensThatCanAttackKing
{
    [TestClass]
    public class Leetcode_1222_QueensThatCanAttackKing_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_CalculateQueensThatCanAttacKing_Then_ShouldReturnNumberOfQueensThatCanAttack()
        {
            //Given
            var queens = new int[6][]
            {
                new int[]{0,1},
                new int[]{1,0},
                new int[]{4,0},
                new int[]{0,4},
                new int[]{3,3},
                new int[]{2,4}
            };
            var king = new int[] { 0, 0 };
            var problem = new Leetcode_1222_QueensThatCanAttackKing_V1();
            var expectedCount = 3;

            //When
            var queents = problem.Calculate(queens, king);

            //Then
            Assert.AreEqual(expectedCount, queents.Count);
        }
    }
}
