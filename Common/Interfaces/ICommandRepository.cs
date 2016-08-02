using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Results;

namespace Common.Interfaces
{
    public interface ICommandRepository<in T>
    {
        Task<CommandResult> SaveChanges(T request);
    }
}
