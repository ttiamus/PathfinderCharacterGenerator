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
    public interface IWeaponService
    {
        Task<Result<IEnumerable<WeaponResponse>>> GetAllWeapons();
        Task<Result<WeaponResponse>> GetWeapon(GetWeaponRequest request);
        Task<Result> CreateWeapon(CreateWeaponRequest request);
        Task<Result> UpdateWeapon(UpdateWeaponRequest request);
        Task<Result> DeleteWeapon(DeleteWeaponRequest request);
    }
}
