using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell
{
    public class Order
    {
        public int UserId {  get; set; }
        public int Year { get; set; }
        public int Count {  get; set; }

        public static Order Create(int year, int count, int userId)
        {
            return new Order() 
            { 
                Year = year,
                Count = count,
                UserId = userId
            };
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            return sb.Append($"\"{nameof(UserId)}:{UserId}\",")
                     .Append($"\"{Year}:{Count}\"")
                     .ToString();
        }
    }

    public class OrdersGenerator
    {
        public static IEnumerable<Order> GenerateOrders()
        {
            var count = 0;
            while (count < 100_000)
            {
                var userId = count % 1000;
                var year = 2000 + count;
                yield return Order.Create(year, count, userId);
                count++;
            }
        }
    }
}
