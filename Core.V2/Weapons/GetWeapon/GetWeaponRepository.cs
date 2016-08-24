using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.Weapons.Models.Responses;

namespace Core.V2.Weapons.GetWeapon
{
    public class GetWeaponRepository : IQueryRepository<GetWeaponRequest, WeaponResponse>
    {
        public Task<Result<WeaponResponse>> SaveChanges(GetWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}