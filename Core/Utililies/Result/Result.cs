using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Result
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Messsage = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
       
        public bool Success { get; }

        public string Messsage { get; }
    }
}
