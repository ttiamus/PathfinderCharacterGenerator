using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IQueryRepository<in T, TU>
    {
        Task<TU> Execute(T request);
    }
}
