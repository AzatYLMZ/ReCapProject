using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Result
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
