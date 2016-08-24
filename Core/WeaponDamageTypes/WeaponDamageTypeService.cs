using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.WeaponDamageTypes.Requests;
using Core.WeaponDamageTypes.Responses;

namespace Core.WeaponDamageTypes
{
    public class WeaponDamageTypeService : IWeaponDamageTypeService
    {
        public async Task<Result<List<WeaponDamageTypeResponse>>> GetWeaponDamageTypes(GetWeaponDamageTypesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}