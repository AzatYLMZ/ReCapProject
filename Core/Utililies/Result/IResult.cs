using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Messsage { get; }
    }
}
