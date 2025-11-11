using System;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-bst-in-binary-tree/description/
    /// </summary>
    public class Leetcode_1373_MaximumSumBSTInBinaryTree_V1
    {
        int maxSum = int.MinValue;
        public int Calculate(TreeNode1373 node)
        {
            CalculateInternal(node, int.MinValue, int.MaxValue);
            return maxSum;
        }

        private Result CalculateInternal(TreeNode1373 node, int leftValue, int rightValue)
        {
            if (node == null)
            {
                return new Result
                {
                    IsBST = true,
                    Sum = 0
                };
            }

            var leftChildResult = CalculateInternal(node.left, leftValue, node.val);
            var rightChildResult = CalculateInternal(node.right, node.val, rightValue);
            if (leftChildResult.IsBST && rightChildResult.IsBST)
            {
                if (node.IsLeaf())
                {
                    maxSum = Math.Max(maxSum, node.val);
                }

                if (node.val > leftValue && node.val < rightValue)
                {
                    var totalSum = leftChildResult.Sum + rightChildResult.Sum + node.val;
                    maxSum = Math.Max(maxSum, totalSum);
                    return new Result
                    {
                        IsBST = true,
                        Sum = totalSum
                    };
                }
            }

            return new Result
            {
                IsBST = false,
                Sum = 0
            };
        }
    }

    public class Result
    {
        public bool IsBST { get; set; }
        public int Sum { get; set; }

        public static Result Create(bool isBst, int sum)
        {
            return new Result
            {
                IsBST = isBst,
                Sum = sum
            };
        }
    }

    public class TreeNode1373
    {
        public int val;
        public TreeNode1373 left;
        public TreeNode1373 right;
        public TreeNode1373(int val = 0, TreeNode1373 left = null, TreeNode1373 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public bool IsLeaf()
        {
            return left == null && right == null;
        }
    }
}
