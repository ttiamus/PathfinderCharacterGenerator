using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Results;

namespace Common.Interfaces
{
    public interface IQueryHandler<in T, TU>
    {
        Task<bool> Validate(T request);
        Task<Result<TU>> Execute(T request);
    }
}
