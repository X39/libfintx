using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    public interface IApiResult
    {
        bool IsSuccess { get; }
    }
    public interface IApiResult<T> : IApiResult
    {
        T Paload { get; }
    }
}
