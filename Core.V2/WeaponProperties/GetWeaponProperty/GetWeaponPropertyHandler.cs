using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.WeaponProperties.GetWeaponProperty
{
    public class GetWeaponPropertyHandler : IQueryHandler<GetWeaponPropertyRequest, WeaponPropertyResponse>
    {
        public Task<Result> Validate(GetWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<WeaponPropertyResponse>> Execute(GetWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}