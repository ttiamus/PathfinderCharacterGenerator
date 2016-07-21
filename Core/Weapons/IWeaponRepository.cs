using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Weapons
{
    public interface IWeaponRepository
    {
        Task<IEnumerable<Weapon>> GetWeapons();
        Task<Weapon> GetWeapon(string id);
        Task InsertWeapon(Weapon weapon);
        Task UpdateWeapon(Weapon weapon);
        Task DeleteWeapon(string id);
    }
}
