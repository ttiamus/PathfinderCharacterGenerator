using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.WeaponDamageTypes.Models.Responses;

namespace Core.V2.WeaponDamageTypes.GetAllWeaponDamageTypes
{
    public class GetAllWeaponDamageTypesRepository : IQueryRepository<GetAllWeaponDamageTypesRequest, List<WeaponDamageTypeResponse>>
    {
        public Task<List<WeaponDamageTypeResponse>> Execute(GetAllWeaponDamageTypesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}