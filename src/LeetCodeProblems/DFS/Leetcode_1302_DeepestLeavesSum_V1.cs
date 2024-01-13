using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DFS
{
    /// <summary>
    /// https://leetcode.com/problems/deepest-leaves-sum/
    /// </summary>
    public class Leetcode_1302_DeepestLeavesSum_V1
    {
        private IDictionary<int, int> leavesLookup = new Dictionary<int, int>();
        public int CalculateDeepestLeavesSum(TreeNode1302 node)
        {
            CalculateSum(node, 0);
            var max = leavesLookup.Keys.Max();
            return leavesLookup[max];
        }

        private void CalculateSum(TreeNode1302 node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                if (!leavesLookup.ContainsKey(level))
                {
                    leavesLookup.Add(level, 0);
                }
                leavesLookup[level] += node.val;
                return;
            }
            CalculateSum(node.left, level + 1);
            CalculateSum(node.right, level + 1);
        }

        public class TreeNode1302
        {
            public int val;
            public TreeNode1302 left;
            public TreeNode1302 right;
        }
    }
}
