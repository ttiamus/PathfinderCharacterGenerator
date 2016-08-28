using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.V2.WeaponDamageTypes.GetAllWeaponDamageTypes;
using Core.V2.WeaponDamageTypes.Models.Responses;

namespace Core.V2.WeaponDamageTypes
{
    public class WeaponDamageTypeService : IWeaponDamageTypeService
    {
        public Task<Result<List<WeaponDamageTypeResponse>>> GetWeaponDamageTypes(GetAllWeaponDamageTypesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}