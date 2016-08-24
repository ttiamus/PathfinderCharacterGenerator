using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.WeaponProperties.GetAllWeaponProperties
{
    public class GetAllWeaponPropertiesRepository : IQueryRepository<GetAllWeaponPropertiesRequest, List<WeaponPropertyResponse>>
    {
        public Task<Result<List<WeaponPropertyResponse>>> SaveChanges(GetAllWeaponPropertiesRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}