using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
    /// </summary>
    public class Leetcode_103_BinaryTreeZigzagLevelOrderTraversal_V1
    {
        public IList<List<int>> ZigzagLevelOrder(TreeNode treeNode)
        {
            var zigZagOrderItems = new List<List<int>>();
            var leftToRightBuffer = new Stack<TreeNode>();
            var rightToLeftBuffer = new Stack<TreeNode>();
            var leftToRightFlag = false;
            rightToLeftBuffer.Push(treeNode);
            var hasNodes = true;
            while (hasNodes)
            {
                if (leftToRightFlag)
                {
                    var nodes = new List<int>();
                    while (leftToRightBuffer.Count > 0)
                    {
                        var node = leftToRightBuffer.Pop();
                        nodes.Add(node.Value);
                        if (node.Right != null)
                        {
                            rightToLeftBuffer.Push(node.Right);
                        }
                        if (node.Left != null)
                        {
                            rightToLeftBuffer.Push(node.Left);
                        }
                    }
                    zigZagOrderItems.Add(nodes);
                }
                else
                {
                    var nodes = new List<int>();
                    while (rightToLeftBuffer.Count > 0)
                    {
                        var node = rightToLeftBuffer.Pop();
                        nodes.Add(node.Value);
                        if (node.Left != null)
                        {
                            leftToRightBuffer.Push(node.Left);
                        }
                        if (node.Right != null)
                        {
                            leftToRightBuffer.Push(node.Right);
                        }
                    }
                    zigZagOrderItems.Add(nodes);
                }

                leftToRightFlag = !leftToRightFlag;
                hasNodes = rightToLeftBuffer.Count > 0 | leftToRightBuffer.Count > 0;
            }

            return zigZagOrderItems;
        }
    }
}
