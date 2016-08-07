using System.Threading.Tasks;
using Common.Results;

namespace Common.Interfaces
{
    public interface ICommandRepository<in T>
    {
        Task<Result> SaveChanges(T request);
    }
}
