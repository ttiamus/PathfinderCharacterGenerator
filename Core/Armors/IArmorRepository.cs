using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Armors
{
    public interface IArmorRepository
    {
        Task<IEnumerable<Armor>> GetArmors();
        Task<Armor> GetArmor(string id);
        Task InsertArmor(Armor armor);
        Task UpdateArmor(Armor armor);
        Task DeleteArmor(string id);
    }
}
