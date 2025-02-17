using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-there-is-a-valid-path-in-a-grid/
    /// </summary>
    public class Leetcode_1391_CheckIfThereIsAValidPathInGrid_V1
    {
        public bool HasValidPath(int[][] grid)
        {
            return false;
        }

        private static IDictionary<int, ISet<int>> GenerateDirectionMappings()
        {
            var mappings = new Dictionary<int, ISet<int>>();

            //Street 1
            mappings.Add(1, new HashSet<int>() { 1, 3, 4, 5, 6 });

            //Street 2
            mappings.Add(2, new HashSet<int>() { 2, 3, 4, 5, 6});

            //Street 3
            mappings.Add(3, new HashSet<int>() { });
            return mappings;
        }
    }
}
