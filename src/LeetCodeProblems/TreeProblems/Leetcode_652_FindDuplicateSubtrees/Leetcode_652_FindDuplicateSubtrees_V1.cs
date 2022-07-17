//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LeetCodeProblems.TreeProblems.Leetcode_652_FindDuplicateSubtrees
//{
//    /// <summary>
//    /// https://leetcode.com/problems/find-duplicate-subtrees/
//    /// </summary>
//    public class Leetcode_652_FindDuplicateSubtrees_V1
//    {
//        public IList<TreeNode> FindDuplicateTrees(TreeNode treeNode)
//        {
//            var duplicateTrees = new List<TreeNode>();
//            var lookup = GenerateLookup(treeNode, new Dictionary<int, IList<TreeNode>>());
//            return duplicateTrees;
//        }

//        private TreeNode FindDuplicateTrees(IList<TreeNode> treeNodes)
//        {
//            foreach (var treeNode in treeNodes)
//            {
//            }
//        }

//        private bool IsIdentical(TreeNode treeOne, TreeNode treeTwo)
//        {
//            if(treeOne == null)
//            return false;
//        }

//        private IDictionary<int, IList<TreeNode>> GenerateLookup(TreeNode node, IDictionary<int, IList<TreeNode>> lookup)
//        {
//            if (node == null)
//            {
//                return lookup;
//            }
//            GenerateLookup(node.left, lookup);
//            GenerateLookup(node.right, lookup);
//            if (!lookup.ContainsKey(node.val))
//            {
//                lookup.Add(node.val, new List<TreeNode>());
//            }
//            lookup[node.val].Add(node);
//            return lookup;
//        }
//    }

//    public class TreeNode : IEqualityComparer<TreeNode>
//    {
//        public TreeNode left { get; set; }
//        public TreeNode right { get; set; }
//        public int val { get; set; }
//        public bool Equals(TreeNode x, TreeNode y)
//        {
//            if (x != null && y != null)
//            {
//                if (x.val != y.val)
//                {
//                    return false;
//                }
//                var leftResult = this.Equals(x.left, y.left);
//                if (!leftResult)
//                {
//                    return false;
//                }
//                var rightResult = this.Equals(x.right, y.right);
//                return rightResult;
//            }
//            else if (x == null && y == null)
//            {
//                return true;
//            }
//            return false;
//        }

//        public int GetHashCode(TreeNode obj)
//        {
//            return obj.GetHashCode();
//        }
//    }
//}
