using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ICommandHandler<in T>
    {
        void Validate(T request);
        Task Execute(T request);
    }
}
