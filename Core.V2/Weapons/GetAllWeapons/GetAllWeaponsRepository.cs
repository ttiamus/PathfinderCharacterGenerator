using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.Weapons.Models.Responses;

namespace Core.V2.Weapons.GetAllWeapons
{
    public class GetAllWeaponsRepository : IQueryRepository<GetAllWeaponsRequest, List<WeaponResponse>>
    {
        public Task<List<WeaponResponse>> Execute(GetAllWeaponsRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}