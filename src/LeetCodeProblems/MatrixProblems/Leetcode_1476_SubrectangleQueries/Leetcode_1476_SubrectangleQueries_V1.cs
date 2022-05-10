using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_1476_SubrectangleQueries
{
    /// <summary>
    /// https://leetcode.com/problems/subrectangle-queries/
    /// </summary>
    public class Leetcode_1476_SubrectangleQueries_V1
    {
        private readonly int[][] _rectangle;
        private readonly IList<UpdateItem> _items;
        public Leetcode_1476_SubrectangleQueries_V1(int[][] rectangle)
        {
            _items = new List<UpdateItem>();
            _rectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            var updateItem = UpdateItem.CreateUpdateItem(row1, col1, row2, col2, newValue);
            _items.Add(updateItem);
        }

        public int GetValue(int row, int col)
        {
            if (_items.Count == 0)
            {
                return _rectangle[row][col];
            }
            for (var index = _items.Count - 1; index >= 0; index--)
            {
                var item = _items[index];
                if (row >= item.Start.Item1 && row <= item.End.Item1)
                {
                    if (col >= item.Start.Item2 && col <= item.End.Item2)
                    {
                        return item.Value;
                    }
                }
            }
            return _rectangle[row][col];
        }
    }

    public class UpdateItem
    {
        public Tuple<int, int> Start { get; set; }
        public Tuple<int, int> End { get; set; }
        public int Value { get; set; }

        public static UpdateItem CreateUpdateItem(int rowStart, int colStart, int rowEnd, int colEnd, int value)
        {
            var updateItem = new UpdateItem
            {
                Start = new Tuple<int, int>(rowStart, colStart),
                End = new Tuple<int, int>(rowEnd, colEnd),
                Value = value
            };
            return updateItem;
        }
    }
}
