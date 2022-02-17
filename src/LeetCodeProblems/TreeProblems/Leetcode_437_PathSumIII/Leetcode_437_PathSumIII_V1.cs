using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_437_PathSumIII
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum-iii/
    /// </summary>
    public class Leetcode_437_PathSumIII_V1
    {
        private IDictionary<int, int> _table;
        private int _sum;
        private int _pathSumCount;
        public int PathSum(TreeNode node, int sum)
        {
            _table = new Dictionary<int, int>();
            _sum = sum;
            CountPathSum(node, 0);
            return _pathSumCount;
        }

        private void CountPathSum(TreeNode node, int pathSum)
        {
            if (node == null)
            {
                return;
            }

            var newSum = node.val + pathSum;
            if (newSum == _sum)
            {
                _pathSumCount += 1;
            }
            var diff = newSum - _sum;
            if (_table.ContainsKey(diff))
            {
                _pathSumCount += _table[diff];
            }

            if (_table.ContainsKey(newSum))
            {
                _table[newSum]++;
            }
            else
            {
                _table.Add(newSum, 1);
            }

            //Traverse left
            CountPathSum(node.left, node.val + pathSum);
            //Traverse right
            CountPathSum(node.right, node.val + pathSum);

            //Backtracking step
            if (_table[newSum] > 1)
            {
                _table[newSum] -= 1;
            }
            else
            {
                _table.Remove(newSum);
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
