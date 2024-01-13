using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DFS
{
    /// <summary>
    /// https://leetcode.com/problems/employee-importance/
    /// </summary>
    public class Leetcode_690_EmployeeImportance_V1
    {
        public int CalculateImportance(IList<Employee> employees, int id)
        {
            var employeesLookup = employees.ToDictionary(employee => employee.id);
            var queue = new Queue<Employee>();
            queue.Enqueue(employeesLookup[id]);
            var importance = 0;
            while (queue.Count > 0)
            {
                var emp = queue.Dequeue();
                importance += emp.importance;
                foreach (var subordinate in emp.subordinates)
                {
                    queue.Enqueue(employeesLookup[subordinate]);
                }
            }
            return importance;
        }

        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }
    }
}
