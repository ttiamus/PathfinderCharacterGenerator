using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.WeaponDamageTypes.Models.Responses;

namespace Core.V2.WeaponDamageTypes.GetWeaponDamageType
{
    public class GetWeaponDamageTypeHandler : IQueryHandler<GetWeaponDamageTypeRequest, WeaponDamageTypeResponse>
    {
        public Task<Result> Validate(GetWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<WeaponDamageTypeResponse>> Execute(GetWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}