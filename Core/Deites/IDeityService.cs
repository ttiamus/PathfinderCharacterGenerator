using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Deites
{
    public interface IDeityService
    {
        Task<IEnumerable<Deity>> GetDeities();
        Task<Deity> GetDeity(string id);
        Task<bool> InsertDeity(Deity Deity);
        Task<bool> UpdateDeity(Deity Deity);
        Task<bool> DeleteDeity(string id);
    }
}
