using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/contest/weekly-contest-348/problems/sum-of-matrix-after-queries/
    /// </summary>
    public class Leetcode_2718_SumOfMatrixAfterQueries_V1
    {
        public int CalculateSum(int rank, int[][] queries)
        {
            var excludedRows = 0;
            var excludedColumns = 0;
            var sum = 0;
            for (var index = 0; index < queries.Length; index++)
            {
                var query = queries[index];

                //When : 
                if (query[0] == 0)
                {

                    excludedRows += 1;
                }
                else
                {
                    excludedColumns += 1;
                }
            }
            return sum;
        }
    }
}
