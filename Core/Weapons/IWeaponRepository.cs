using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Weapons.Requests;
using Core.Weapons.Responses;

namespace Core.Weapons
{
    public interface IWeaponRepository
    {
        Task<Result<IEnumerable<WeaponResponse>>> GetWeapons();
        Task<Result<WeaponResponse>> GetWeapon(GetWeaponRequest request);
        Task<Result> InsertWeapon(InsertWeaponRequest request);
        Task<Result> UpdateWeapon(UpdateWeaponRequest request);
        Task<Result> DeleteWeapon(DeleteWeaponRequest request);
    }
}
