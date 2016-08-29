using System.Threading.Tasks;
using Common.Results;

namespace Common.Interfaces
{
    public interface ICommandHandler<in T>
    {
        void Validate(T request);
        Task Execute(T request);
    }
}
