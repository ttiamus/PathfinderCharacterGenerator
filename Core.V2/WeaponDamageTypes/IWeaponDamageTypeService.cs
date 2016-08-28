using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.V2.WeaponDamageTypes.GetAllWeaponDamageTypes;
using Core.V2.WeaponDamageTypes.Models.Responses;

namespace Core.V2.WeaponDamageTypes
{
    public interface IWeaponDamageTypeService
    {
        Task<Result<List<WeaponDamageTypeResponse>>> GetWeaponDamageTypes(GetAllWeaponDamageTypesRequest request);
    }
}