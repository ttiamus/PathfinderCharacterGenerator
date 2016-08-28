using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.WeaponDamageTypes.Models.Responses;

namespace Core.V2.WeaponDamageTypes.GetAllWeaponDamageTypes
{
    public class GetAllWeaponDamageTypesRepository : IQueryRepository<GetAllWeaponDamageTypesRequest, List<WeaponDamageTypeResponse>>
    {
        public Task<Result<List<WeaponDamageTypeResponse>>> SaveChanges(GetAllWeaponDamageTypesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}