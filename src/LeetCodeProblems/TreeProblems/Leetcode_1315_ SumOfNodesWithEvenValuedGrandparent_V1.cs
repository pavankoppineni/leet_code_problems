using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/
    /// </summary>
    public class Leetcode_1315__SumOfNodesWithEvenValuedGrandparent_V1
    {
        public int CalculateSumOfNodes(TreeNode1315 treeNode)
        {
            return CalculateSumofNodes(treeNode, null, null);
        }

        private int CalculateSumofNodes(TreeNode1315 current, TreeNode1315 parent, TreeNode1315 grandParent)
        {
            var sum = 0;
            if (current == null)
            {
                return sum;
            }

            sum += CalculateSumofNodes(current.left, current, parent);
            sum += CalculateSumofNodes(current.right, current, parent);

            // When : node has grand parent
            // Then : Do not add current node value
            if (grandParent == null)
            {
                return sum;
            }

            // When : node has grand parent and grand parent value is EVEN
            // Then : Add current node value
            if (grandParent.val % 2 == 0)
            {
                return sum + current.val;
            }

            // When : node has grand parent and grand parent value is ODD
            // Then : Do not add current node value
            return sum;
        }
    }

    public class TreeNode1315
    {
        public TreeNode1315 left { get; set; }
        public TreeNode1315 right { get; set; }
        public int val { get; set; }
    }

}
