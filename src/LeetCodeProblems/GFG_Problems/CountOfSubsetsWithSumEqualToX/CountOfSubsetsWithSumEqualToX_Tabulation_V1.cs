using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GFG_Problems.CountOfSubsetsWithSumEqualToX
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-of-subsets-with-sum-equal-to-x/
    /// </summary>
    public class CountOfSubsetsWithSumEqualToX_Tabulation_V1
    {
        public int CountOfSubsetsWithSumEqualToX(int[] arr, int sum)
        {
            var rows = arr.Length + 1;
            var columns = sum + 1;
            var table = new int[rows, columns];
            table[0, 0] = 1;
            for(var row = 1; row < rows; row++)
            {
                var item = arr[row];
                for (var col = 0; col < columns; col++)
                {
                    //Case 1 : When item is greater than col
                    //Action : Get value from previous row and same column
                    if (item > col)
                    {
                        table[row, col] = table[row - 1, col];
                    }
                    //Case 2 : When item is less than or equal to col
                    //Action : Get count from following places
                    //1. Include item
                    //2. Exclude item
                    else
                    {
                        var includeItemCount = table[row - 1, col - item];
                        var excludeItemCount = table[row - 1, col];
                        table[row, col] = includeItemCount + excludeItemCount;
                    }
                }
            }

            return table[rows - 1, columns - 1];
        }
    }
}
