using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems.Leetcode_318_MaximumProductOfWordLengths
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-of-word-lengths/
    /// </summary>
    public class Leetcode_318_MaximumProductOfWordLengths_V1
    {
        public int CalculateProduct(string[] words)
        {
            var maxProduct = 0;
            var numbers = CalculateNumbers(words);
            for (var index = 0; index < numbers.Length; index++)
            {
                for (var nestedIndex = index + 1; nestedIndex < numbers.Length; nestedIndex++)
                {
                    if ((numbers[nestedIndex] & numbers[index]) == 0)
                    {
                        var product = words[nestedIndex].Length * words[index].Length;
                        if (product > maxProduct)
                        {
                            maxProduct = product;
                        }
                    }
                }
            }
            return maxProduct;
        }

        private int[] CalculateNumbers(string[] words)
        {
            var numbers = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                foreach (var item in words[i])
                {
                    numbers[i] |= 1 << item - 'a';
                }
            }
            return numbers;
        }
    }
}
