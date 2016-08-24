using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.Weapons.Models.Responses;

namespace Core.V2.Weapons.GetAllWeapons
{
    public class GetAllWeaponsHandler : IQueryHandler<GetAllWeaponsRequest, List<WeaponResponse>>
    {
        public Task<Result> Validate(GetAllWeaponsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<List<WeaponResponse>>> Execute(GetAllWeaponsRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}