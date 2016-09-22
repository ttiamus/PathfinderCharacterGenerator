using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.WeaponDamageTypes.Models.Responses;

namespace Core.V2.WeaponDamageTypes.GetWeaponDamageType
{
    public class GetWeaponDamageTypeRepository : IQueryRepository<GetWeaponDamageTypeRequest, WeaponDamageTypeResponse>
    {
        public Task<WeaponDamageTypeResponse> Execute(GetWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}