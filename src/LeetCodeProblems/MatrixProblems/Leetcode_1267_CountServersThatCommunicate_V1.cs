using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-servers-that-communicate/description/?envType=problem-list-v2&envId=matrix
    /// </summary>
    public class Leetcode_1267_CountServersThatCommunicate_V1
    {
        public int CalculateNumberOfComputers(int[][] computersGrid)
        {
            var rowsCount = computersGrid.Length;
            var colsCount = computersGrid[0].Length;
            var colsLookup = new Dictionary<int, int>();
            var rowsLookup = new Dictionary<int, int>();

            var numberOfComputers = 0;
            for (var row = 0; row < rowsCount; row++)
            {
                for (var col = 0; col < colsCount; col++)
                {
                    var value = computersGrid[row][col];
                    if (value == 0)
                    {
                        continue;
                    }

                    if (!rowsLookup.ContainsKey(row))
                    {
                        rowsLookup.Add(row, 0);
                    }
                    rowsLookup[row] += 1;

                    if (!colsLookup.ContainsKey(col))
                    {
                        colsLookup.Add(col, 0);
                    }
                    colsLookup[col] += 1;
                }
            }


            for (var row = 0; row < rowsCount; row++)
            {
                for (var col = 0; col < colsCount; col++)
                {
                    var value = computersGrid[row][col];
                    if (value == 0)
                    {
                        continue;
                    }

                    if (rowsLookup.ContainsKey(row) && rowsLookup[row] > 1)
                    {
                        numberOfComputers += 1;
                        continue;
                    }

                    if(colsLookup.ContainsKey(col) && colsLookup[col] > 1)
                    {
                        numberOfComputers += 1;
                        continue;
                    }
                }
            }

            return numberOfComputers;
        }
    }
}
