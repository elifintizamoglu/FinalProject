using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult //sen aynı zamanda bir IResultsın ve ek olarak T türünde data içereceksin
    {
        T Data { get; }

    }
}
