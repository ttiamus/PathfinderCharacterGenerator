using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ICommandRepository<in T>
    {
        Task SaveChanges(T request);
    }
}
