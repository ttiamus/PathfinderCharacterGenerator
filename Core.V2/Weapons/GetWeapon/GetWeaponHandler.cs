using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.Weapons.Models.Responses;

namespace Core.V2.Weapons.GetWeapon
{
    public class GetWeaponHandler : IQueryHandler<GetWeaponRequest, WeaponResponse>
    {
        public void Validate(GetWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<WeaponResponse> Execute(GetWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}