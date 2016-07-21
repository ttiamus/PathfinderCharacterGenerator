using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Deites
{
    public interface IDeityRepository
    {
        Task<IEnumerable<Deity>> GetDeities();
        Task<Deity> GetDeity(string id);
        Task InsertDeity(Deity deity);
        Task UpdateDeity(Deity deity);
        Task DeleteDeity(string id);
    }
}
