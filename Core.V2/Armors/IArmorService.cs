using System.Collections.Generic;
using System.Threading.Tasks;
using Core.V2.Armors.Models.Data;

namespace Core.V2.Armors
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
