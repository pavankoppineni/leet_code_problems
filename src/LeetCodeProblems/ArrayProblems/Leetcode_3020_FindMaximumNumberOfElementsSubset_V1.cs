using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-number-of-elements-in-subset
    /// </summary>
    public class Leetcode_3020_FindMaximumNumberOfElementsSubset_V1
    {
        public int CalculateMaximumNumberOfElements(int[] elements)
        {
            throw new NotImplementedException();
        }
    }

    public class ElementValue
    {
        public int Count { get; set; }
        public int PreviousExponent {  get; set; }

        public static ElementValue Create() => new ElementValue();
    }
}
