using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/longest-univalue-path/description/
    /// </summary>
    public class Leetcode_687_LongestUnivaluePath_V1
    {
        int _longestPath = int.MinValue;
        public int Calculate(TreeNode687 root)
        {
            return 1;
        }

        public Result687 CalculateInternal(TreeNode687 node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.left == null && node.right == null)
            {
                _longestPath = Math.Max(_longestPath, 1);
                new Result687 { Value = node.val, LongestPath = 1 };
            }

            if (node.left == null)
            {
                return GetResult(node, CalculateInternal(node.right));
            }

            if (node.right == null)
            {
                return GetResult(node, CalculateInternal(node.left));
            }

            return null;

        }

        private Result687 GetResult(TreeNode687 node, Result687 childResult)
        {
            if (node.val == childResult.Value)
            {
                var currentRightLongestPath = childResult.LongestPath + 1;
                _longestPath = Math.Max(_longestPath, currentRightLongestPath);
                return new Result687 { Value = node.val, LongestPath = currentRightLongestPath };
            }

            _longestPath = Math.Max(_longestPath, 1);
            return new Result687 { Value = node.val, LongestPath = 1 };
        }

        private Result687 GetResult(TreeNode687 node, Result687 leftChildResult, Result687 rightChildResult)
        {
            var currentLongestPath = 0;
            if (node.val == leftChildResult.Value)
            {
                if (node.val == rightChildResult.Value)
                {
                    currentLongestPath = leftChildResult.LongestPath + rightChildResult.LongestPath + 1;
                    _longestPath = Math.Max(_longestPath, currentLongestPath);
                }

                currentLongestPath = leftChildResult.LongestPath + 1;
                _longestPath = Math.Max(currentLongestPath, _longestPath);
                return new Result687 { Value = node.val, LongestPath = _longestPath };
            }

            if (node.val == rightChildResult.Value)
            {
                currentLongestPath = rightChildResult.LongestPath + 1;
                _longestPath = Math.Max(currentLongestPath, _longestPath);
                return new Result687 { LongestPath = currentLongestPath, Value = node.val };
            }

            _longestPath = Math.Max(_longestPath, 1);
            return new Result687
            {
                LongestPath = 1,
                Value = node.val
            };
        }
    }

    public class Result687
    {
        public int Value { get; set; }
        public int LongestPath { get; set; }
    }

    public class TreeNode687
    {
        public int val;
        public TreeNode687 left;
        public TreeNode687 right;
    }
}
