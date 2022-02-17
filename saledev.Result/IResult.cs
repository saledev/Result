using System;
using System.Collections.Generic;

namespace saledev.Result
{
    public interface IResult
    {
        ResultStatus Status { get; }
        IEnumerable<string> Errors { get; }
        List<ValidationError> ValidationErrors { get; }
        Type ValueType { get; }
        Object GetValue();
        PagedInfo GetPagedInfo();
    }
}
