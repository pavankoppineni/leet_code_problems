using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Shell.LoadBalancer
{
    public interface IRequest
    {
        Guid Id { get; set; }
        string Data { get; set; }
    }

    public class Request : IRequest
    {
        public Guid Id { get; set; }
        public string Data { get; set; }

        public static IRequest Create(string data)
        {
            return new Request { Id = Guid.NewGuid(), Data = data };
        }
    }
}
