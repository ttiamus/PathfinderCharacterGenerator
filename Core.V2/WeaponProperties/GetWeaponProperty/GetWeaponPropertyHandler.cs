using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.WeaponProperties.GetWeaponProperty
{
    public class GetWeaponPropertyHandler : IQueryHandler<GetWeaponPropertyRequest, WeaponPropertyResponse>
    {
        public void Validate(GetWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<WeaponPropertyResponse> Execute(GetWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}