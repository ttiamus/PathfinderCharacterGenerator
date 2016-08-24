using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.WeaponDamageTypes.Requests;
using Core.WeaponDamageTypes.Responses;

namespace Core.WeaponDamageTypes
{
    public interface IWeaponDamageTypeService
    {
        Task<Result<List<WeaponDamageTypeResponse>>> GetWeaponDamageTypes(GetWeaponDamageTypesRequest request);
    }
}