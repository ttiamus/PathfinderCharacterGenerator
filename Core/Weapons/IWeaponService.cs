using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Weapons
{
    public interface IWeaponService
    {
        Task<IEnumerable<Weapon>> GetWeapons();
        Task<Weapon> GetWeapon(string id);
        Task<bool> InsertWeapon(Weapon weapon);
        Task<bool> UpdateWeapon(Weapon weapon);
        Task<bool> DeleteWeapon(string id);
    }
}
