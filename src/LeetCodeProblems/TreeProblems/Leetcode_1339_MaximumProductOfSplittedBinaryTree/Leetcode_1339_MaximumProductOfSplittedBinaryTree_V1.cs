using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_1339_MaximumProductOfSplittedBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-of-splitted-binary-tree/
    /// </summary>
    public class Leetcode_1339_MaximumProductOfSplittedBinaryTree_V1
    {
        private int _maxProduct;
        private int _totalSum;
        public int CalculateMaxProduct(TreeNode root)
        {
            PostOrderTranversal(root);
            _totalSum = root.sum;
            CalculateRootSum(root);
            return _maxProduct;
        }

        private void CalculateRootSum(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            var remainingSum = _totalSum - node.sum;
            var currentProduct = remainingSum * node.sum;
            if (currentProduct > _maxProduct)
            {
                _maxProduct = currentProduct;
            }
            CalculateRootSum(node.left);
            CalculateRootSum(node.right);
        }

        private int PostOrderTranversal(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var leftSum = PostOrderTranversal(root.left);
            var rightSum = PostOrderTranversal(root.right);
            root.sum = root.val + leftSum + rightSum;
            return root.sum;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public int sum;
    }
}
