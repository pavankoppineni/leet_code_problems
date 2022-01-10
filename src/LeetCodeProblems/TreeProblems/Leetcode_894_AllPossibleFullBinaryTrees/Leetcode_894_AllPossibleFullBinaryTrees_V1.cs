using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_894_AllPossibleFullBinaryTrees
{
    /// <summary>
    /// https://leetcode.com/problems/all-possible-full-binary-trees/
    /// </summary>
    public class Leetcode_894_AllPossibleFullBinaryTrees_V1
    {
        public IList<TreeNode> GenerateAllPossibleFullBinaryTrees(int nodeCount)
        {
            if ((nodeCount & 1) == 0)
            {
                return Array.Empty<TreeNode>();
            }

            return GenerateAllPossibleFullBinaryTrees(1, nodeCount);
        }

        private IList<TreeNode> GenerateAllPossibleFullBinaryTrees(int start, int end)
        {
            if (start == end)
            {
                var leafNode = new TreeNode();
                return new List<TreeNode>() { leafNode };
            }

            var treeNodes = new List<TreeNode>();
            var rootIndex = start + 1;
            while (rootIndex < end)
            {
                var leftNodes = GenerateAllPossibleFullBinaryTrees(start, rootIndex - 1);
                var rightNodes = GenerateAllPossibleFullBinaryTrees(rootIndex + 1, end);
                foreach (var leftNode in leftNodes)
                {
                    foreach (var rightNode in rightNodes)
                    {
                        var node = new TreeNode();
                        node.left = leftNode;
                        node.right = rightNode;
                        treeNodes.Add(node);
                    }
                }
                rootIndex += 2;
            }
            return treeNodes;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode right;
        public TreeNode left;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
