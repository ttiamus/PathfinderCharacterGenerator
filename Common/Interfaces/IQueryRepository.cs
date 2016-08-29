using System.Threading.Tasks;
using Common.Results;

namespace Common.Interfaces
{
    public interface IQueryRepository<in T, TU>
    {
        Task<TU> Execute(T request);
    }
}
