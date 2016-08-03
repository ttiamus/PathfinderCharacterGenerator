using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Results;

namespace Common.Interfaces
{
    public interface ICommandHandler<in T>
    {
        Task<bool> Validate(T request);
        Task<Result> Execute(T request);
    }
}
