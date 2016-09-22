using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IQueryHandler<in T, TU>
    {
        void Validate(T request);
        Task<TU> Execute(T request);
    }
}
