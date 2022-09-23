using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_331_VerifyPreorderSerializationOfBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/verify-preorder-serialization-of-a-binary-tree/
    /// </summary>
    public class Leetcode_331_VerifyPreorderSerializationOfBinaryTree_V1
    {
        private string[] _preOrderArray;
        public bool ValidateSerialization(string preorder)
        {
            var charArray = preorder.Split(',');
            _preOrderArray = charArray;
            var result = Validate(0);
            if (result.result)
            {
                return result.index == _preOrderArray.Length - 1;
            }
            return false;
        }

        private (bool result, int index) Validate(int index)
        {
            if (index >= _preOrderArray.Length)
            {
                return (false, index);
            }
            if (_preOrderArray[index] == "#")
            {
                return (true, index);
            }
            var left = Validate(index + 1);
            if (!left.result)
            {
                return (false, index);
            }
            return Validate(left.index + 1);
        }
    }
}
