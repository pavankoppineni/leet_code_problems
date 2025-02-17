using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-in-binary-tree/
    /// </summary>
    public class Leetcode_1367_LinkedListInBinaryTree_V1
    {
        public bool IsSubPath(ListNode1367 listNode, TreeNode1367 treeNode)
        {
            var values = ConvertToList(listNode);
            var lpsArray = ConstructLPS(values);
            return IsSubPatch(values, lpsArray, 0, treeNode);
        }

        private bool IsSubPatch(IList<int> values, int[] lps, int index, TreeNode1367 treeNode)
        {
            if (index == values.Count)
            {
                return true;
            }

            if (treeNode == null)
            {
                return false;
            }

            if (treeNode.val == values[index])
            {
                var isValid = IsSubPatch(values, lps, index + 1, treeNode.left)
                    || IsSubPatch(values, lps, index + 1, treeNode.right);
                if (isValid)
                {
                    return true;
                }
            }
            var newIndexPos = index == 0 ? 0 : lps[index - 1];
            return IsSubPatch(values, lps, newIndexPos, treeNode);
        }

        private IList<int> ConvertToList(ListNode1367 listNode)
        {
            var values = new List<int>();
            var currentNode = listNode;
            while (currentNode != null)
            {
                values.Add(currentNode.val);
                currentNode = currentNode.next;
            }
            return values;
        }

        public int[] ConstructLPS(IList<int> values)
        {
            var lpsArray = new int[values.Count];
            var offset = 0;
            var index = 1;
            while (index < values.Count)
            {
                if (values[index] == values[offset])
                {
                    lpsArray[index] = lpsArray[index - 1] + 1;
                    index++;
                    offset++;
                    continue;
                }

                offset = 0;
                if (values[index] == values[offset])
                {
                    lpsArray[index] = 1;
                    offset++;
                }
                index++;
            }
            return lpsArray;
        }
    }

    public class ListNode1367
    {
        public int val { get; set; }
        public ListNode1367 next { get; set; }
    }

    public class TreeNode1367
    {
        public int val { get; set; }
        public TreeNode1367 left { get; set; }
        public TreeNode1367 right { get; set; }
    }
}
