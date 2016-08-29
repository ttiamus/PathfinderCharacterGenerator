using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.WeaponDamageTypes.Models.Responses;

namespace Core.V2.WeaponDamageTypes.GetAllWeaponDamageTypes
{
    public class GetAllWeaponDamageTypesHandler : IQueryHandler<GetAllWeaponDamageTypesRequest, List<WeaponDamageTypeResponse>>
    {
        public void Validate(GetAllWeaponDamageTypesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<WeaponDamageTypeResponse>> Execute(GetAllWeaponDamageTypesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}