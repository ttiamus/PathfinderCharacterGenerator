using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.V2.Weapons.CreateWeapon;
using Core.V2.Weapons.DeleteWeapon;
using Core.V2.Weapons.GetWeapon;
using Core.V2.Weapons.Models.Responses;
using Core.V2.Weapons.UpdateWeapon;

namespace Core.V2.Weapons
{
    public class WeaponService : IWeaponService
    {
        public Task<Result<IEnumerable<WeaponResponse>>> GetAllWeapons()
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<WeaponResponse>> GetWeapon(GetWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> CreateWeapon(CreateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> UpdateWeapon(UpdateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> DeleteWeapon(DeleteWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
