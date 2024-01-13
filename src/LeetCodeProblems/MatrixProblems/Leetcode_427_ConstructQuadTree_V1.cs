using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// 
    /// </summary>
    public class Leetcode_427_ConstructQuadTree_V1
    {
        private int[][] _grid;
        public Node427 ConstructQuadTree(int[][] grid)
        {
            _grid = grid;
            var start = new Coordinates(0, 0);
            var end = new Coordinates(grid.Length - 1, grid.Length - 1);
            return ConstructNode(start, end);
        }

        private Node427 ConstructNode(Coordinates start, Coordinates end)
        {
            if (start.X == end.X)
            {
                return new Node427(_grid[start.X][start.Y], true);
            }
            var topLeftNodeCoordinates = Coordinates.GetTopLeftCoordinates(start, end);
            var topRightCoordinates = Coordinates.GetTopRightCoordinates(start, end);
            var bottomLeftNodeCoordinates = Coordinates.GetBottomLeftCoordinates(start, end);
            var bottomRightNodeCoordinates = Coordinates.GetBottomRightCoordinates(start, end);

            var topLeftNode = ConstructNode(topLeftNodeCoordinates.start, topLeftNodeCoordinates.end);
            var topRightNode = ConstructNode(topRightCoordinates.start, topRightCoordinates.end);
            var bottomLeftNode = ConstructNode(bottomLeftNodeCoordinates.start, bottomLeftNodeCoordinates.end);
            var bottomRightNode = ConstructNode(bottomRightNodeCoordinates.start, bottomRightNodeCoordinates.end);
            var parentNode = Node427.CreateParentNode(topLeftNode, topRightNode, bottomLeftNode, bottomRightNode);
            return parentNode;
        }
    }

    public class Coordinates
    {
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public static (Coordinates start, Coordinates end) GetTopLeftCoordinates(Coordinates start, Coordinates end)
        {
            var mid = (end.X - start.X) / 2;
            var newStart = new Coordinates(start.X, start.Y);
            var newEnd = new Coordinates(start.X + mid, start.Y + mid);
            return (newStart, newEnd);
        }

        public static (Coordinates start, Coordinates end) GetTopRightCoordinates(Coordinates start, Coordinates end)
        {
            var mid = (end.X - start.X) / 2;
            var newStart = new Coordinates(start.X, start.X + mid + 1);
            var newEnd = new Coordinates(start.X + mid, end.Y);
            return (newStart, newEnd);
        }

        public static (Coordinates start, Coordinates end) GetBottomLeftCoordinates(Coordinates start, Coordinates end)
        {
            var mid = (end.X - start.X) / 2;
            var newStart = new Coordinates(start.X + mid + 1, start.X);
            var newEnd = new Coordinates(end.Y, start.X + mid);
            return (newStart, newEnd);
        }

        public static (Coordinates start, Coordinates end) GetBottomRightCoordinates(Coordinates start, Coordinates end)
        {
            var mid = (end.X - start.X) / 2;
            var newStart = new Coordinates(start.X + mid + 1, start.X + mid + 1);
            var newEnd = new Coordinates(end.X, end.Y);
            return (newStart, newEnd);
        }
    }

    public class Node427
    {
        public Node427(int value, bool isLeaf)
        {
            this.val = 1 == value;
            this.isLeaf = isLeaf;
            this.value = value;
        }
        public int value;
        public bool val;
        public bool isLeaf;
        public Node427 topLeft;
        public Node427 topRight;
        public Node427 bottomLeft;
        public Node427 bottomRight;

        public static Node427 CreateParentNode(Node427 topLeft, Node427 topRight, Node427 bottomLeft, Node427 bottomRight)
        {
            var count = topLeft.value + topRight.value + bottomLeft.value + bottomRight.value;
            if (count == 0 || count == 4)
            {
                return new Node427(count == 4 ? 1 : 0, true);
            }
            var parentNode = new Node427(1, false)
            {
                topLeft = topLeft,
                topRight = topRight,
                bottomLeft = bottomLeft,
                bottomRight = bottomRight
            };
            return parentNode;
        }
    }
}
