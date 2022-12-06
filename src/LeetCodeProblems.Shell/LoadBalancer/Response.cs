using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Shell.LoadBalancer
{
    public enum ResponseCode
    {
        Ok,
        NotFound,
        InternalServerError
    }
    public interface IResponse
    {
        Guid Id { get; set; }
        ResponseCode ResponseCode { get; set; }
    }

    public class Response : IResponse
    {
        public Guid Id { get; set; }
        public ResponseCode ResponseCode { get; set; }

        public static IResponse Ok(Guid id) => Create(id, ResponseCode.Ok);

        public static IResponse NotFound(Guid id) => Create(id, ResponseCode.NotFound);

        public static IResponse InternalServerError(Guid id) => Create(id, ResponseCode.InternalServerError);

        private static IResponse Create(Guid id, ResponseCode responseCode)
        {
            return new Response { ResponseCode = responseCode, Id = id };
        }
    }
}
