//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCodeProblems.MatrixProblems
//{
//    /// <summary>
//    /// https://leetcode.com/problems/find-the-safest-path-in-a-grid
//    /// </summary>
//    public class Leetcode_2812_FindTheSafestPathInGrid_V1
//    {
//        private static IList<(int row, int col)> _directions = new List<(int row, int col)>
//        {
//            (0, 1), //Right
//            (0, -1), //Left
//            (1, 0), //Down
//            (-1, 0) //Up
//        };
//        public int CalculateSafenessFactor(IList<IList<int>> grid)
//        {
//            if(grid.Count == 0)
//            {
//                return 0;
//            }

//            var rows = grid.Count;
//            var cols = grid[0].Count;
//            if (grid[0][0] == 1 || grid[rows - 1][cols - 1] == 1)
//            {
//                return 0;
//            }

//            var visited = new bool[rows, cols];
//        }

//        private int CalculateSafenessFactor(int row, int col, bool[,] visited,)
//        {

//        }

//        private int[][] ConstructSafenessMatrix(IList<IList<int>> grid)
//        {
//            var rows = grid.Count;
//            var cols = grid[0].Count;
//            var visited = new bool[rows, cols];
//            var safenessMatrix = new int[rows][];
//            var thiefPositions = GetThiefPositions(grid);
//            while (thiefPositions.Count > 0)
//            {
//                var currentCell = thiefPositions.Dequeue();
//                var row = currentCell.row;
//                var column = currentCell.col;
//                foreach (var direction in _directions)
//                {
//                    var newRow = row + direction.row;
//                    var newCol = column + direction.col;

//                    if (newRow < 0 || newCol < 0)
//                    {
//                        continue;
//                    }

//                    if (newRow >= rows || newCol >= cols)
//                    {
//                        continue;
//                    }

//                    if (visited[newRow, newCol])
//                    {
//                        continue;
//                    }

//                    safenessMatrix[newRow][newCol] = currentCell.safeness + 1;
//                    visited[newRow, newCol] = true;
//                    thiefPositions.Enqueue((newRow, newCol, currentCell.safeness + 1));
//                }
//            }

//            return safenessMatrix;
//        }

//        private static Queue<(int row, int col, int safeness)> GetThiefPositions(IList<IList<int>> grid)
//        {
//            var positions = new Queue<(int row, int col, int safeness)>();
//            var rows = grid.Count;
//            var cols = grid[0].Count;
//            for (var row = 0; row < rows; row++)
//            {
//                for (var col = 0; col < cols; col++)
//                {
//                    if (grid[row][col] == 1)
//                    {
//                        positions.Enqueue((row, col, 0));
//                    }
//                }
//            }

//            return positions;
//        }
//    }
//}
