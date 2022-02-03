using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.RecursionProblems.Leetcode_60_PermutationSequence
{
    /// <summary>
    /// https://leetcode.com/problems/permutation-sequence/
    /// </summary>
    public class Leetcode_60_PermutationSequence_V1
    {
        private int[] _permutationNumber;
        private IList<int> _numberDictionary;
        public string GetPermutation(int n, int k)
        {
            _numberDictionary = Enumerable.Range(1, n).ToList();
            _permutationNumber = new int[n];
            var factorial = CalculateFactorial(n);
            GeneratePermutation(0, factorial, n, k);
            var result = string.Empty;
            foreach (var num in _permutationNumber)
            {
                result += num.ToString();
            }
            return result;
        }

        private int CalculateFactorial(int n)
        {
            var result = 1;
            while (n > 0)
            {
                result *= n;
                n--;
            }
            return result;
        }

        private void GeneratePermutation(int index, int factorial, int n, int k)
        {
            if (k == 0 || n == 0)
            {
                return;
            }

            var groupCount = factorial / n;
            var quotient = (k - 1) / groupCount;
            _permutationNumber[index] = _numberDictionary[quotient];
            _numberDictionary.RemoveAt(quotient);
            GeneratePermutation(index + 1, groupCount, n - 1, k - quotient * groupCount);
        }
    }
}
