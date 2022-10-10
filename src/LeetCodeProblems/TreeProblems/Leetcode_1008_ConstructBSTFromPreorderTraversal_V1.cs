//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LeetCodeProblems.TreeProblems
//{
//    /// <summary>
//    /// https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
//    /// </summary>
//    public class Leetcode_1008_ConstructBSTFromPreorderTraversal
//    {
//        private int[] _values;
//        public Node_1008 ConstructTreeFromPreorder(int[] values)
//        {
//            _values = values;
//        }

//        /// <summary>
//        /// Constructs tree from 
//        /// </summary>
//        /// <param name="startInclusive"></param>
//        /// <param name="endInclusive"></param>
//        /// <returns></returns>
//        private Node_1008 ConstructTree(int startInclusive, int endInclusive)
//        {
//            if (startInclusive > endInclusive)
//            {
//                return null;
//            }

//            if (startInclusive == endInclusive)
//            {
//                return new Node_1008 { Value = _values[startInclusive] };
//            }
//            var node = new Node_1008 { Value = _values[startInclusive] };
//            var leftIndex = FindIndex(startInclusive + 1, endInclusive, startInclusive);
//            if(leftIndex != -1)
//            {
//                var rightIndex = FindIndex
//            }
//            return node;
//        }

//        private int FindIndex(int startInclusive, int endInclusive, int nodeIndex)
//        {
//            if (startInclusive > endInclusive)
//            {
//                return -1;
//            }

//            if (startInclusive == endInclusive)
//            {
//                return startInclusive;
//            }
//            var value = _values[nodeIndex];
//            var mid = startInclusive + (endInclusive - startInclusive) / 2;

//            if (value > _values[mid])
//            {
//                return FindIndex(mid, endInclusive, nodeIndex);
//            }
//            return FindIndex(startInclusive, mid - 1, nodeIndex);
//        }
//    }

//    public class Node_1008
//    {
//        public int Value { get; set; }
//        public Node_1008 Left { get; set; }
//        public Node_1008 Right { get; set; }
//    }
//}
