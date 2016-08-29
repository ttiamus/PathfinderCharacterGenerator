using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.WeaponProperties.GetAllWeaponProperties
{
    public class GetAllWeaponPropertiesHandler : IQueryHandler<GetAllWeaponPropertiesRequest, List<WeaponPropertyResponse>>
    {
        public void Validate(GetAllWeaponPropertiesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<WeaponPropertyResponse>> Execute(GetAllWeaponPropertiesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}