using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeetCodeProblems.Shell
{
    public class Program
    {
        public static void Main()
        {
            var records = new List<Record>();
            records.Add(Record.Create());
            records.Add(Record.Create());
            var grouped = records.GroupBy(i => new { i.Employee });
            foreach (var group in grouped)
            {
                foreach(var item in group)
                {
                    Console.WriteLine(item.Employee.LastName);
                    Console.WriteLine(item.Employee.FirstName);
                }
            }
        }
    }

    public class Record
    {
        public string Key { get; set; }
        public Employee Employee { get; set; }

        public static Record Create()
        {
            return new Record
            {
                Key = Guid.NewGuid().ToString(),
                Employee = Employee.Create()
            };
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static Employee Create()
        {
            return new Employee
            {
                FirstName = nameof(FirstName),
                LastName = Guid.NewGuid().ToString(),
            };
        }

        public override bool Equals(object obj)
        {
            var dest = (Employee)obj;
            return dest.FirstName == FirstName;// && dest.LastName == LastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode();
        }
    }
}
