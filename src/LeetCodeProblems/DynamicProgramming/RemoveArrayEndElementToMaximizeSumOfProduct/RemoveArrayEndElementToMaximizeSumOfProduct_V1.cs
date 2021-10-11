using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.RemoveArrayEndElementToMaximizeSumOfProduct
{
    /// <summary>
    /// https://www.geeksforgeeks.org/remove-array-end-element-maximize-sum-product/
    /// </summary>
    public class RemoveArrayEndElementToMaximizeSumOfProduct_v1
    {
        private IList<int> _paths;
        public int MaximizeSumOfProduct(int[] values)
        {
            _paths = new List<int>();
            MaximizeSumOfProduct(0, values.Length - 1, values, 0, 1);
            return _paths.Max();
        }

        //private void MaximizeSumOfProduct(int start, int end, int[] values, Stack<int> pathSum)
        //{
        //    if (start == end)
        //    {
        //        pathSum.Push(values[start]);
        //        _paths.Add(pathSum.ToArray());
        //        pathSum.Pop();
        //        return;
        //    }

        //    pathSum.Push(values[start]);
        //    MaximizeSumOfProduct(start + 1, end, values, pathSum);
        //    pathSum.Pop();
        //    pathSum.Push(values[end]);
        //    MaximizeSumOfProduct(start, end - 1, values, pathSum);
        //    pathSum.Pop();
        //}

        private void MaximizeSumOfProduct(int start, int end, int[] values, int pathSum, int rank)
        {
            if (start == end)
            {
                pathSum += rank * values[start];
                _paths.Add(pathSum);
                return;
            }

            pathSum += rank * values[start];
            MaximizeSumOfProduct(start + 1, end, values, pathSum, rank + 1);
            pathSum -= rank * values[start];
            pathSum += rank * values[end];
            MaximizeSumOfProduct(start, end - 1, values, pathSum, rank + 1);
        }
    }
}
