using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Armors
{
    public interface IArmorService
    {
        Task<IEnumerable<Armor>> GetArmors();
        Task<Armor> GetArmor(string id);
        Task<bool> InsertArmor(Armor armor);
        Task<bool> UpdateArmor(Armor armor);
        Task<bool> DeleteArmor(string id);
    }
}
