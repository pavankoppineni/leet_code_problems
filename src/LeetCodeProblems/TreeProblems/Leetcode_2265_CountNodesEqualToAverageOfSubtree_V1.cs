using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-nodes-equal-to-average-of-subtree/
    /// </summary>
    public class Leetcode_2265_CountNodesEqualToAverageOfSubtree_V1
    {
        public int CalculateAverageOfSubtree(TreeNode_2265 node)
        {
            var treeDecorator = TreeNodeDecorator.CreateFrom(node);
            var averageLookup = new Dictionary<int, int>();
            return -1;
        }

        private int CalculateNodesWithSameAverage(TreeNodeDecorator nodeDecorator, IDictionary<int, int> averageLookup)
        {
            var node = nodeDecorator.Node;
            if (node == null)
            {
                return 0;
            }

            var average = nodeDecorator.Sum / nodeDecorator.Count;
            if (!averageLookup.ContainsKey(average))
            {
                averageLookup.Add(average, 0);
            }
            averageLookup[average] += 1;
            var leftCount = CalculateNodesWithSameAverage(nodeDecorator.Left, averageLookup);
            var rightCount = CalculateNodesWithSameAverage(nodeDecorator.Right, averageLookup);
            if (node.val == average)
            {
                return leftCount + rightCount + 1;
            }
            return leftCount + rightCount;
        }
    }

    public class TreeNode_2265
    {
        public int val;
        public TreeNode_2265 left;
        public TreeNode_2265 right;
    }

    public class TreeNodeDecorator
    {
        public static TreeNodeDecorator Empty = new TreeNodeDecorator(null, 0, 0);

        public TreeNodeDecorator(TreeNode_2265 node, int sum, int count)
        {
            Node = node;
            Sum = sum;
            Count = count;
        }

        public TreeNode_2265 Node { get; }
        public TreeNodeDecorator Left { get; set; }
        public TreeNodeDecorator Right { get; set; }
        public int Sum { get; }
        public int Count { get; }

        public static TreeNodeDecorator CreateFrom(TreeNode_2265 node)
        {
            if (node == null)
            {
                return TreeNodeDecorator.Empty;
            }

            var leftDecorator = CreateFrom(node.left);
            var rightDecorator = CreateFrom(node.right);
            var sum = leftDecorator.Sum + rightDecorator.Sum + node.val;
            var count = rightDecorator.Count + leftDecorator.Count + 1;
            var decorator = new TreeNodeDecorator(node, sum, count);
            decorator.Left = leftDecorator;
            decorator.Right = rightDecorator;
            return decorator;
        }
    }
}

