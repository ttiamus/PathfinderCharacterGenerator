using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.WeaponProperties.GetWeaponProperty
{
    public class GetWeaponPropertyRepository : IQueryRepository<GetWeaponPropertyRequest, WeaponPropertyResponse>
    {
        public Task<Result<WeaponPropertyResponse>> SaveChanges(GetWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}