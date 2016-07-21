using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Weapons
{
    public class WeaponService : IWeaponService
    {
        public Task<IEnumerable<Weapon>> GetWeapons()
        {
            throw new System.NotImplementedException();
        }

        public Task<Weapon> GetWeapon(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertWeapon(Weapon weapon)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateWeapon(Weapon weapon)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteWeapon(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
