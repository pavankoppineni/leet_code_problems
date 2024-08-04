using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/
    /// </summary>
    public class Leetcode_238_ProductOfArrayExceptSelf_V1
    {
        public int[] CalculateProductArray(int[] values)
        {
            var productArray = new int[values.Length];
            var previousProduct = 1;
            for (int i = 0; i < values.Length; i++)
            {
                productArray[i] = previousProduct;
                previousProduct *= productArray[i];
            }

            previousProduct = 1;
            for (int i = values.Length - 1; i >= 0; i--)
            {
                productArray[i] *= previousProduct;
                previousProduct *= productArray[i];
            }
            return productArray;
        }
    }
}
