using System.Threading.Tasks;
using Common.Results;

namespace Common.Interfaces
{
    public interface ICommandRepository<in T>
    {
        Task SaveChanges(T request);
    }
}
