using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.Weapons.Models.Responses;

namespace Core.V2.Weapons.GetAllWeapons
{
    public class GetAllWeaponsHandler : IQueryHandler<GetAllWeaponsRequest, List<WeaponResponse>>
    {
        public void Validate(GetAllWeaponsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<WeaponResponse>> Execute(GetAllWeaponsRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}